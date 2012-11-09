SELECT DISTINCT
	star_contexts.context AS context_id,
	star_contexts.star_contexttypeid AS context_type_uri
 FROM
	star_contexts
WHERE
	star.contexts.star_contexttypeid <> ''
