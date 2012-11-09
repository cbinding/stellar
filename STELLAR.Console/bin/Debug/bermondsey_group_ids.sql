SELECT DISTINCT
'GP-' || SITECODE || '-' || GP AS GROUP_ID
FROM FLD_IND3D_GPS
UNION
SELECT DISTINCT
'SGP-' || SITECODE || '-' || SGP AS GROUP_ID
FROM FLD_IND3D_GPS