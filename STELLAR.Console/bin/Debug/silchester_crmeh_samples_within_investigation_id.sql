SELECT 
	finds.sfno AS sample_id,
	'SILCHESTER' AS within_investigation_id
FROM
	finds
WHERE 
	rec_type = 'SA';
