<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0"  exclude-result-prefixes="xsl ext"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:skos="http://www.w3.org/2004/02/skos/core#" 
	xmlns:ecrm="http://erlangen-crm.org/101001/" 
	xmlns:crmeh="http://purl.org/crmeh#" 
	xmlns:dc="http://purl.org/dc/elements/1.1/" 
	xmlns:dcterms="http://purl.org/dc/terms/"
	xmlns:ext="stellar:ext">
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>
	
	<xsl:param name="BASE_URI" select="'http://tempuri#'"/>
	
	<xsl:include href="CRMEH.xslt"/>
			
	<xsl:template match="/">
		<rdf:RDF>
			<xsl:for-each select="//row">
				<xsl:call-template name="CRMEH_INVESTIGATION">
					<xsl:with-param name="INVESTIGATION_ID" select="col[@name = 'investigation_id']"/>
					<xsl:with-param name="INVESTIGATION_TYPE" select="col[@name = 'investigation_type']"/>
					<xsl:with-param name="INVESTIGATION_TYPE_URI" select="col[@name = 'investigation_type_uri']"/>
					<xsl:with-param name="INVESTIGATION_TIMESPAN" select="col[@name = 'investigation_timespan']"/>
					<xsl:with-param name="INVESTIGATION_DESCRIPTION" select="col[@name = 'investigation_description']"/>
					<xsl:with-param name="INVESTIGATION_LOCATION" select="col[@name = 'investigation_location']"/>	
					<xsl:with-param name="LANGUAGE" select="col[@name = 'language']"/>				
				</xsl:call-template>
			</xsl:for-each>			
		</rdf:RDF>
	</xsl:template>	
</xsl:stylesheet>
