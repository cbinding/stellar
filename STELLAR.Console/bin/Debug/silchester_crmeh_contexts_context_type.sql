SELECT DISTINCT
	context AS context_id,
	type AS context_type
FROM 
	contexts
WHERE
	type <> ''
