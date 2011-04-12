<?xml version="1.0" encoding="UTF-8"?>
<!--STELLAR template library for creating all SKOS entities and relationships (unfinished)-->
<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl ext"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:skos="http://www.w3.org/2004/02/skos/core#" 
	xmlns:dcterms="http://purl.org/dc/terms/"
	xmlns:ext="stellar:ext">
	
	<xsl:import href="RDF.xslt"/>
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>		
	
	<!--template creates a URI of the format {BASE_URI}{TYPE}_{ID}-->
	<xsl:template name="SKOS_URI">
		<!--<xsl:param name="TYPE"/>-->
		<xsl:param name="ID"/>
		
		<xsl:value-of select="normalize-space($BASE_URI)"/>
		<!--<xsl:value-of select="normalize-space($TYPE)"/>
		<xsl:text>_</xsl:text>-->
		<!--<xsl:value-of select="normalize-space($ID)"/>--><!--and lowercase - reduce inconsistency?-->
		<xsl:value-of select="ext:URLEncode($ID)"/>

		<!--<xsl:value-of select="escape-html-uri(normalize-space($ID))"/>-->
	</xsl:template>	

	
	<!--template creates a skos:Concept-->
	<xsl:template name="SKOS_CONCEPT">
		<xsl:param name="CONCEPT_ID"/>
		<xsl:param name="SCHEME_ID"/>
		<xsl:param name="BROADER_ID"/>
		<xsl:param name="RELATED_ID"/>
		<xsl:param name="PREFLABEL"/>
		<xsl:param name="ALTLABEL"/>	
		<xsl:param name="HIDDENLABEL"/>				
		<xsl:param name="NOTE"/>
		<xsl:param name="SCOPENOTE"/>
		<xsl:param name="CHANGENOTE"/>
		<xsl:param name="DEFINITION"/>
		<xsl:param name="EDITORIALNOTE"/>
		<xsl:param name="EXAMPLE"/>
		<xsl:param name="HISTORYNOTE"/>	
			
		<xsl:param name="LANGUAGE"/>		
		
		<!--Create the Concept URI-->
		<xsl:variable name="CONCEPT_URI">
			<xsl:call-template name="SKOS_URI">
				<!--<xsl:with-param name="TYPE">CONCEPT</xsl:with-param>-->
				<xsl:with-param name="ID" select="$CONCEPT_ID"/>
			</xsl:call-template>
		</xsl:variable>

		<!--Create the Concept Entity-->
		<skos:Concept>
			<xsl:call-template name="RDF_ABOUT">
				<xsl:with-param name="URI" select="$CONCEPT_URI"/>
			</xsl:call-template>
			<xsl:call-template name="RDFS_LABEL">
				<xsl:with-param name="LBL" select="$PREFLABEL"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>		
		</skos:Concept>
		
		<!--Concept inScheme ConceptScheme-->	
		<xsl:if test="normalize-space($SCHEME_ID) != ''">
			<xsl:variable name="SCHEME_URI">
				<xsl:call-template name="SKOS_URI">
					<!--<xsl:with-param name="TYPE">SCHEME</xsl:with-param>-->
					<xsl:with-param name="ID" select="$SCHEME_ID"/>
				</xsl:call-template>
			</xsl:variable>

			<xsl:call-template name="SKOS_X_INSCHEME_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_URI" select="$SCHEME_URI"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept broader Concept-->	
		<xsl:if test="normalize-space($BROADER_ID) != ''">
			<xsl:variable name="BROADER_URI">
				<xsl:call-template name="SKOS_URI">
					<!--<xsl:with-param name="TYPE">CONCEPT</xsl:with-param>-->
					<xsl:with-param name="ID" select="$BROADER_ID"/>
				</xsl:call-template>
			</xsl:variable>

			<xsl:call-template name="SKOS_X_BROADER_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_URI" select="$BROADER_URI"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept RELATED Concept-->	
		<xsl:if test="normalize-space($RELATED_ID) != ''">
			<xsl:variable name="RELATED_URI">
				<xsl:call-template name="SKOS_URI">
					<!--<xsl:with-param name="TYPE">CONCEPT</xsl:with-param>-->
					<xsl:with-param name="ID" select="$RELATED_ID"/>
				</xsl:call-template>
			</xsl:variable>
			
			<xsl:call-template name="SKOS_X_RELATED_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_URI" select="$RELATED_URI"/>
			</xsl:call-template>	
		</xsl:if>
		
		<!--Concept prefLabel value-->	
		<xsl:if test="normalize-space($PREFLABEL) != ''">
			<xsl:call-template name="SKOS_X_PREFLABEL_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$PREFLABEL"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept altLabel value-->	
		<xsl:if test="normalize-space($ALTLABEL) != ''">
			<xsl:call-template name="SKOS_X_ALTLABEL_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$ALTLABEL"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept hiddenLabel value-->	
		<xsl:if test="normalize-space($HIDDENLABEL) != ''">
			<xsl:call-template name="SKOS_X_HIDDENLABEL_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$HIDDENLABEL"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>

		
		<!--Concept note value-->	
		<xsl:if test="normalize-space($NOTE) != ''">
			<xsl:call-template name="SKOS_X_NOTE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$NOTE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept scopeNote value-->	
		<xsl:if test="normalize-space($SCOPENOTE) != ''">
			<xsl:call-template name="SKOS_X_SCOPENOTE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$SCOPENOTE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept changeNote value-->	
		<xsl:if test="normalize-space($CHANGENOTE) != ''">
			<xsl:call-template name="SKOS_X_CHANGENOTE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$CHANGENOTE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept definition value-->	
		<xsl:if test="normalize-space($DEFINITION) != ''">
			<xsl:call-template name="SKOS_X_DEFINITION_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$DEFINITION"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>

		<!--Concept editorialNote value-->	
		<xsl:if test="normalize-space($EDITORIALNOTE) != ''">
			<xsl:call-template name="SKOS_X_EDITORIALNOTE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$EDITORIALNOTE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Concept example value-->	
		<xsl:if test="normalize-space($EXAMPLE) != ''">
			<xsl:call-template name="SKOS_X_EXAMPLE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$EXAMPLE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>

		<!--Concept historyNote value-->	
		<xsl:if test="normalize-space($HISTORYNOTE) != ''">
			<xsl:call-template name="SKOS_X_HISTORYNOTE_Y">
				<xsl:with-param name="X_URI" select="$CONCEPT_URI"/>
				<xsl:with-param name="Y_VAL" select="$HISTORYNOTE"/>
				<xsl:with-param name="LANGUAGE" select="$LANGUAGE"/>
			</xsl:call-template>
		</xsl:if>	
		
	</xsl:template>

	
	<!--template creates a skos:ConceptScheme-->
	<xsl:template name="SKOS_CONCEPTSCHEME">
		<xsl:param name="SCHEME_ID"/>
		<xsl:param name="TITLE"/>
		<xsl:param name="DESCRIPTION"/>
		<xsl:param name="CREATOR"/>
		<xsl:param name="TOPCONCEPT_ID"/>
		<xsl:param name="LANGUAGE"/>
		
		<!--Create the ConceptScheme URI-->
		<xsl:variable name="SCHEME_URI">
			<xsl:call-template name="SKOS_URI">
				<!--<xsl:with-param name="TYPE">SCHEME</xsl:with-param>-->
				<xsl:with-param name="ID" select="$SCHEME_ID"/>
			</xsl:call-template>
		</xsl:variable>
		
		<!--Create the ConceptScheme Entity-->
		<skos:ConceptScheme>
			<xsl:call-template name="RDF_ABOUT">
				<xsl:with-param name="URI" select="$SCHEME_URI"/>
			</xsl:call-template>
			
			<xsl:if test="normalize-space($TITLE) != ''">
				<dcterms:title>
					<xsl:if test="normalize-space($LANGUAGE) != ''">
						<xsl:attribute name="xml:lang">
							<xsl:value-of select="normalize-space($LANGUAGE)"/>
						</xsl:attribute>
					</xsl:if>
					<xsl:value-of select="normalize-space($TITLE)"/>
				</dcterms:title>
			</xsl:if>
			
			<xsl:if test="normalize-space($DESCRIPTION) != ''">
				<dcterms:description>
					<xsl:if test="normalize-space($LANGUAGE) != ''">
						<xsl:attribute name="xml:lang">
							<xsl:value-of select="normalize-space($LANGUAGE)"/>
						</xsl:attribute>
					</xsl:if>
					<xsl:value-of select="normalize-space($DESCRIPTION)"/>
				</dcterms:description>
			</xsl:if>
			
			<xsl:if test="normalize-space($CREATOR) != ''">
				<dcterms:creator>
					<xsl:if test="normalize-space($LANGUAGE) != ''">
						<xsl:attribute name="xml:lang">
							<xsl:value-of select="normalize-space($LANGUAGE)"/>
						</xsl:attribute>
					</xsl:if>
					<xsl:value-of select="normalize-space($CREATOR)"/>
				</dcterms:creator>
			</xsl:if>
		</skos:ConceptScheme>
			
		<!--Scheme hasTopConcept Concept-->	
		<xsl:if test="normalize-space($TOPCONCEPT_ID) != ''">
			<xsl:variable name="CONCEPT_URI">
				<xsl:call-template name="SKOS_URI">
					<!--<xsl:with-param name="TYPE">CONCEPT</xsl:with-param>-->
					<xsl:with-param name="ID" select="$TOPCONCEPT_ID"/>
				</xsl:call-template>
			</xsl:variable>
				
			<xsl:call-template name="SKOS_X_TOPCONCEPT_Y">
				<xsl:with-param name="X_URI" select="$SCHEME_URI"/>
				<xsl:with-param name="Y_URI" select="$CONCEPT_URI"/>
			</xsl:call-template>	
		</xsl:if>

		
	</xsl:template>

	<!--template implements property X skos:hasTopConcept Y-->
	<xsl:template name="SKOS_X_TOPCONCEPT_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>		
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:hasTopConcept rdf:resource="{$Y_URI}"/>
		</rdf:Description>	
		
		<rdf:Description rdf:about="{$Y_URI}">
			<skos:topConceptOf rdf:resource="{$X_URI}"/>
		</rdf:Description>
		
	</xsl:template>

	<!--template implements property X skos:prefLabel Y-->
	<xsl:template name="SKOS_X_PREFLABEL_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:prefLabel>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:prefLabel>
		</rdf:Description>
	</xsl:template>

	<!--template implements property X skos:altLabel Y-->
	<xsl:template name="SKOS_X_ALTLABEL_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:altLabel>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:altLabel>
		</rdf:Description>
	</xsl:template>
	
	<!--template implements property X skos:hiddenLabel Y-->
	<xsl:template name="SKOS_X_HIDDENLABEL_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:hiddenLabel>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:hiddenLabel>
		</rdf:Description>
	</xsl:template>

	
	<!--template implements property X skos:inScheme Y-->
	<xsl:template name="SKOS_X_INSCHEME_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:inScheme rdf:resource="{$Y_URI}"/>
		</rdf:Description>			
		
	</xsl:template>
	

	<!--template implements property X skos:broader Y & Y skos:narrower X-->
	<xsl:template name="SKOS_X_BROADER_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:broader rdf:resource="{$Y_URI}"/>
		</rdf:Description>	
		
		<rdf:Description rdf:about="{$Y_URI}">
			<skos:narrower rdf:resource="{$X_URI}"/>
		</rdf:Description>
		
	</xsl:template>
	
	<!--template implements property X skos:related Y & Y skos:related X-->
	<xsl:template name="SKOS_X_RELATED_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_URI"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:related rdf:resource="{$Y_URI}"/>
		</rdf:Description>	
		
		<rdf:Description rdf:about="{$Y_URI}">
			<skos:related rdf:resource="{$X_URI}"/>
		</rdf:Description>
		
	</xsl:template>
	
	<!--template implements property X skos:scopeNote Y-->
	<xsl:template name="SKOS_X_NOTE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:note>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:note>
		</rdf:Description>
	</xsl:template>		
	
	<!--template implements property X skos:scopeNote Y-->
	<xsl:template name="SKOS_X_SCOPENOTE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:scopeNote>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:scopeNote>
		</rdf:Description>
	</xsl:template>
	
	<!--template implements property X skos:changeNote Y-->
	<xsl:template name="SKOS_X_CHANGENOTE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:changeNote>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:changeNote>
		</rdf:Description>
	</xsl:template>	
	
	<!--template implements property X skos:definition Y-->
	<xsl:template name="SKOS_X_DEFINITION_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:definition>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:definition>
		</rdf:Description>
	</xsl:template>

	<!--template implements property X skos:editorialNote Y-->
	<xsl:template name="SKOS_X_EDITORIALNOTE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:editorialNote>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:editorialNote>
		</rdf:Description>
	</xsl:template>
	
	<!--template implements property X skos:editorialNote Y-->
	<xsl:template name="SKOS_X_EXAMPLE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:example>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:example>
		</rdf:Description>
	</xsl:template>

	<!--template implements property X skos:historyNote Y-->
	<xsl:template name="SKOS_X_HISTORYNOTE_Y">
		<xsl:param name="X_URI"/>
		<xsl:param name="Y_VAL"/>
		<xsl:param name="LANGUAGE"/>
		
		<rdf:Description rdf:about="{$X_URI}">
			<skos:historyNote>
				<xsl:if test="normalize-space($LANGUAGE) != ''">
					<xsl:attribute name="xml:lang">
						<xsl:value-of select="normalize-space($LANGUAGE)"/>
					</xsl:attribute>
				</xsl:if>
				<xsl:value-of select="$Y_VAL"/>
			</skos:historyNote>
		</rdf:Description>
	</xsl:template>	
	
	

	
</xsl:stylesheet>
