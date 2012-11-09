SELECT
	finds.sfno AS find_id,
	finds.name AS find_type
FROM finds
WHERE rec_type <> 'SA'
AND finds.name <> '';