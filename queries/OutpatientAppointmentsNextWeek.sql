/*
    Oracle Cerner Millennium V500 Schema
    Outpatient Appointments for the Next Week

    Description:
        Returns all outpatient appointments scheduled within the next 7 days.
        Includes the schedule slot ID (SCHEDULE_ID and SCHEDULE_SEQ from SCH_APPT)
        so each appointment can be linked back to its clinic template via
        SCH_SCHEDULE.SCH_TEMPLATE_ID.

    Key Tables:
        SCH_APPT        - Scheduling appointment (slot and schedule info)
        SCH_EVENT        - Scheduling event (appointment event wrapper)
        ENCOUNTER        - Patient encounter (used to filter outpatient)
        PERSON           - Patient demographics
        CODE_VALUE       - Lookup table for coded values

    Slot-to-Clinic-Template Linkage:
        SCH_APPT.SCHEDULE_ID  ->  SCH_SCHEDULE.SCHEDULE_ID
        SCH_SCHEDULE.SCH_TEMPLATE_ID  ->  SCH_TEMPLATE.SCH_TEMPLATE_ID
*/

SELECT
    sa.SCH_APPT_ID,
    sa.SCHEDULE_ID,                                 -- Slot ID: links to SCH_SCHEDULE for clinic template
    sa.SCHEDULE_SEQ,                                -- Sequence within the schedule slot
    se.SCH_EVENT_ID,
    sa.BEG_DT_TM                    AS appt_start,
    sa.END_DT_TM                    AS appt_end,
    sa.DURATION,
    sa.APPT_TYPE_CD,
    cv_appt_type.DISPLAY            AS appt_type_display,
    se.SCH_STATE_CD,
    cv_state.DISPLAY                AS appt_state_display,
    e.ENCNTR_ID,
    e.ENCNTR_TYPE_CD,
    cv_encntr_type.DISPLAY          AS encntr_type_display,
    p.PERSON_ID,
    p.NAME_FULL_FORMATTED           AS patient_name,
    p.BIRTH_DT_TM                   AS date_of_birth,
    cv_sex.DISPLAY                  AS sex,
    e.LOC_FACILITY_CD,
    cv_facility.DISPLAY             AS facility_display,
    e.LOC_NURSE_UNIT_CD,
    cv_nurse_unit.DISPLAY           AS clinic_display,
    sa.RESOURCE_CD,
    cv_resource.DISPLAY             AS resource_display
FROM
    SCH_APPT sa
    INNER JOIN SCH_EVENT se
        ON sa.SCH_EVENT_ID = se.SCH_EVENT_ID
        AND se.ACTIVE_IND = 1
        AND se.END_EFFECTIVE_DT_TM > SYSDATE
    INNER JOIN ENCOUNTER e
        ON sa.ENCNTR_ID = e.ENCNTR_ID
        AND e.ACTIVE_IND = 1
        AND e.END_EFFECTIVE_DT_TM > SYSDATE
    INNER JOIN PERSON p
        ON e.PERSON_ID = p.PERSON_ID
        AND p.ACTIVE_IND = 1
        AND p.END_EFFECTIVE_DT_TM > SYSDATE
    -- Appointment type lookup
    LEFT JOIN CODE_VALUE cv_appt_type
        ON sa.APPT_TYPE_CD = cv_appt_type.CODE_VALUE
    -- Appointment state lookup
    LEFT JOIN CODE_VALUE cv_state
        ON se.SCH_STATE_CD = cv_state.CODE_VALUE
    -- Encounter type lookup
    LEFT JOIN CODE_VALUE cv_encntr_type
        ON e.ENCNTR_TYPE_CD = cv_encntr_type.CODE_VALUE
    -- Sex lookup
    LEFT JOIN CODE_VALUE cv_sex
        ON p.SEX_CD = cv_sex.CODE_VALUE
    -- Facility lookup
    LEFT JOIN CODE_VALUE cv_facility
        ON e.LOC_FACILITY_CD = cv_facility.CODE_VALUE
    -- Nurse unit / clinic lookup
    LEFT JOIN CODE_VALUE cv_nurse_unit
        ON e.LOC_NURSE_UNIT_CD = cv_nurse_unit.CODE_VALUE
    -- Resource lookup
    LEFT JOIN CODE_VALUE cv_resource
        ON sa.RESOURCE_CD = cv_resource.CODE_VALUE
WHERE
    sa.ROLE_MEANING = 'PATIENT'                     -- Patient-level appointment rows
    AND sa.STATE_MEANING IN ('CONFIRMED', 'CHECKED IN', 'SCHEDULED')
    AND sa.ACTIVE_IND = 1
    AND sa.END_EFFECTIVE_DT_TM > SYSDATE
    AND sa.BEG_DT_TM >= TRUNC(SYSDATE)
    AND sa.BEG_DT_TM <  TRUNC(SYSDATE) + 7
    AND e.ENCNTR_TYPE_CLASS_CD = (                  -- Outpatient encounter type class
        SELECT CODE_VALUE
        FROM CODE_VALUE
        WHERE CDF_MEANING = 'OUTPATIENT'
            AND CODE_SET = 69
            AND ACTIVE_IND = 1
    )
ORDER BY
    sa.BEG_DT_TM ASC,
    p.NAME_FULL_FORMATTED ASC
;
