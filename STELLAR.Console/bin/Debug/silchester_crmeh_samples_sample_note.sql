SELECT 
	finds_treat.fno AS sample_id,
	finds_treat.details AS sample_note
FROM 
	finds_treat
WHERE 
	rec_type = 'SA'
AND 
	finds_treat.details <>''
UNION
SELECT
	finds.sfno AS sample_id,
	finds.name AS sample_note
FROM
	finds
WHERE 
	rec_type = 'SA'
AND 
	finds.name <>'';