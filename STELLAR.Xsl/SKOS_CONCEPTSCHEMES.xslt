<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0"  exclude-result-prefixes="xsl ext"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:skos="http://www.w3.org/2004/02/skos/core#" 
	xmlns:ecrm="http://purl.org/NET/crm-owl#" 
	xmlns:crmeh="http://purl.org/crmeh#" 
	xmlns:dc="http://purl.org/dc/elements/1.1/" 
	xmlns:dcterms="http://purl.org/dc/terms/"
	xmlns:ext="stellar:ext">
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>
	
	<xsl:param name="BASE_URI" select="'http://tempuri#'"/>
	
	<xsl:include href="SKOS.xslt"/>
			
	<xsl:template match="/">
		<rdf:RDF>
			<xsl:for-each select="//row">
				<xsl:call-template name="SKOS_CONCEPTSCHEME">
					<xsl:with-param name="SCHEME_ID" select="col[@name = 'scheme_id']"/>
					<xsl:with-param name="TITLE" select="col[@name = 'title']"/>	
					<xsl:with-param name="DESCRIPTION" select="col[@name = 'description']"/>
					<xsl:with-param name="CREATOR" select="col[@name = 'creator']"/>
					<xsl:with-param name="TOPCONCEPT_ID" select="col[@name = 'topconcept_id']"/>
					<xsl:with-param name="LANGUAGE" select="col[@name = 'language']"/>
				</xsl:call-template>
			</xsl:for-each>			
		</rdf:RDF>
	</xsl:template>	
</xsl:stylesheet>
