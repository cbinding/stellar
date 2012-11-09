SELECT 
	finds.sfno AS find_id,
	'SILCHESTER' AS within_investigation_id
FROM
	finds
WHERE 
	finds.rec_type <> 'SA';
