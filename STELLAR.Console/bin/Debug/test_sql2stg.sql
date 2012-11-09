SELECT DISTINCT
	context AS item1,
	type AS item2,
	'ggg' AS item3,
	'hhh' AS item4
FROM 
	contexts
WHERE
	type <> ''
