SELECT
	finds.sfno AS find_id,
	finds.context AS within_context_id
FROM finds
WHERE rec_type <> 'SA';