SELECT DISTINCT
	upper(finds.material) AS concept_id,
	'materials' AS scheme_id,
	upper(finds.material) AS preflabel
FROM
	finds;
