SELECT DISTINCT
SITECODE || '-' || ACC_NO AS FIND_ID, 
TYPE AS FIND_TYPE,
MATE AS FIND_MATERIAL,
E_DATE AS PRODUCTION_EDATE,
L_DATE AS PRODUCTION_LDATE,
COMMENTS AS FIND_NOTE
FROM FND_COIN