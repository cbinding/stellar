SELECT
	context AS context_id,
	descrip AS context_note
FROM 
	contexts
WHERE
	descrip <> ''
UNION SELECT
	context AS context_id,
	compsn AS context_note
FROM 
	contexts
WHERE
	compsn <> ''
UNION SELECT
	context AS context_id,
	notes AS context_note
FROM 
	contexts
WHERE
	notes <> ''