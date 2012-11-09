SELECT
	finds.sfno AS find_id,
	finds.material AS find_material
FROM finds
WHERE rec_type <> 'SA'
AND finds.material <> '';