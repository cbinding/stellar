<?xml version="1.0" encoding="UTF-8"?>
<!--
	template library for creating CLAROS entities and relationships -	experimental 
	templates to assess how well CLAROS templates fit into STELLAR approach
	Created by Ceri Binding, University of Glamorgan
	
	Revision History:
	=============================================================================== 
	Ref	Date		   Who	Description
	=============================================================================== 
	1.0	2010-11-09	CFB	Initially created template library
-->
<!DOCTYPE xsl:stylesheet [
	<!ENTITY xsd "http://www.w3.org/2001/XMLSchema#">
	<!ENTITY claros "http://purl.org/NET/Claros/vocab#">

]>
<xsl:stylesheet version="2.0" exclude-result-prefixes="xsl"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:xsd="http://www.w3.org/2001/XMLSchema#"
	xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" 
	xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" 
	xmlns:ecrm="http://purl.org/NET/crm-owl#"
	xmlns:geo="http://www.w3.org/2003/01/geo/wgs84_pos#" 
	xmlns:claros="http://purl.org/NET/Claros/vocab#">
	
	<xsl:import href="ECRM.xslt"/>
	
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:preserve-space elements="*"/>		
	
	<!--CLAROS_OBJECT-->
	<xsl:template name="CLAROS_OBJECT">
		<xsl:param name="OBJECT_URI"/>
		<xsl:param name="OBJECT_ID"/>
		<xsl:param name="OBJECT_LABEL"/>
		<xsl:param name="OBJECT_TITLE"/>
		<xsl:param name="PERIOD_BEGIN"/>
		<xsl:param name="PERIOD_END"/>
		<xsl:param name="OBJECT_TYPE"/>	
		<xsl:param name="OBJECT_TYPE_URI"/>		
		<xsl:param name="THUMB_URI"/>
		<xsl:param name="THUMB_LABEL"/>
		<xsl:param name="IMAGE_URI"/>
		<xsl:param name="IMAGE_LABEL"/>
		<xsl:param name="PAGE_URI"/>
		<xsl:param name="REFERENCE"/>

		<!--TODO: other properties of CLAROS_OBJECT not yet implemented..-->
		
		
		<!--Create the Man-Made_Object Entity-->
		<xsl:call-template name="ECRM_E22">
			<xsl:with-param name="URI" select="normalize-space($OBJECT_URI)"/>
			<xsl:with-param name="LBL" select="normalize-space($OBJECT_LABEL)"/>
		</xsl:call-template>	
		
		<!--Man-Made_Object has_preferred_identifier Identifier-->
		<xsl:if test="normalize-space($OBJECT_ID) != ''">
			<xsl:call-template name="ECRM_X_P48_Y">
				<xsl:with-param name="X_URI" select="normalize-space($OBJECT_URI)"/>
				<xsl:with-param name="Y_OBJ">
					<xsl:call-template name="ECRM_E42">
						<xsl:with-param name="VAL">
							<xsl:value-of select="normalize-space($OBJECT_ID)"/>
						</xsl:with-param>							
					</xsl:call-template>
				</xsl:with-param>	
			</xsl:call-template>		
		</xsl:if>
		
		<!--Man-Made_Object has_title Title-->
		<xsl:if test="normalize-space($OBJECT_TITLE) != ''">
			<xsl:call-template name="ECRM_X_P102_Y">
				<xsl:with-param name="X_URI" select="normalize-space($OBJECT_URI)"/>
				<xsl:with-param name="Y_OBJ">
					<xsl:call-template name="ECRM_E35">
						<xsl:with-param name="VAL">
							 <xsl:value-of select="normalize-space($OBJECT_TITLE)"/>
						</xsl:with-param>
					</xsl:call-template>
				</xsl:with-param>				
			</xsl:call-template>
		</xsl:if>			
		
		<!--Man-Made_Object has_type Type-->
		<!--OBJECT_TYPE_URI specified-->		
		<xsl:if test="normalize-space($OBJECT_TYPE_URI) != ''">
			<!--create the Type entity-->
			<xsl:call-template name="ECRM_E55">
				<xsl:with-param name="URI" select="normalize-space($OBJECT_TYPE_URI)"/>
				<xsl:with-param name="VAL">
					<xsl:value-of select="normalize-space($OBJECT_TYPE)"/>
				</xsl:with-param>
			</xsl:call-template>			
			<!--Man-Made_Object has_type Type-->
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="normalize-space($OBJECT_URI)"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_TYPE_URI)"/>
			</xsl:call-template>	
		</xsl:if>		
		
		<!--OBJECT_TYPE_URI not specified but OBJECT_TYPE specified-->
		<xsl:if test="normalize-space($OBJECT_TYPE_URI) = '' and normalize-space($OBJECT_TYPE) != ''">
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="normalize-space($OBJECT_URI)"/>
				<xsl:with-param name="Y_OBJ">
					<xsl:call-template name="ECRM_E55">
						<xsl:with-param name="VAL">
							<xsl:value-of select="normalize-space($OBJECT_TYPE)"/>
						</xsl:with-param> 
					</xsl:call-template>
				</xsl:with-param>							
			</xsl:call-template>
		</xsl:if>
		<!--End Man-Made_Object has_type Type-->
		
		<!--PERIOD_BEGIN / PERIOD_END-->
		<xsl:if test="normalize-space($PERIOD_BEGIN) != ''">
			<!--Create the Production Event URI-->
			<xsl:variable name="E12_URI" select="concat(normalize-space($OBJECT_URI),'_E12')"/>
			
			<!--Create the Production Event-->
			<xsl:call-template name="ECRM_E12">
				<xsl:with-param name="URI" select="$E12_URI"/>				
			</xsl:call-template>	
			
			<!--Link the production Event to the Object-->
			<xsl:call-template name="ECRM_X_P108_Y">
				<xsl:with-param name="X_URI" select="$E12_URI"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_URI)"/>
			</xsl:call-template>
			
			<!--Link the production Event to a TimeSpan-->
			<xsl:call-template name="ECRM_X_P4_Y">
				<xsl:with-param name="X_URI" select="$E12_URI"/>
				<xsl:with-param name="Y_OBJ">			
					<ecrm:E52_Time-Span>
						<!--Link the Time-Span to a claros:Period-->					
						<ecrm:P82_at_some_time_within>
							<claros:Period>
								<claros:period_begin rdf:datatype="&xsd;gYear">
									<xsl:value-of select="$PERIOD_BEGIN"/>
								</claros:period_begin>
		    					<claros:period_end rdf:datatype="&xsd;gYear">
		    						<xsl:value-of select="$PERIOD_END"/>
								</claros:period_end>
							</claros:Period>
						</ecrm:P82_at_some_time_within>
					</ecrm:E52_Time-Span>
				</xsl:with-param>
			</xsl:call-template>			
		</xsl:if>
		<!--End PERIOD_BEGIN / PERIOD_END-->	
		
		<!--Man-Made_Object has_representation Image (thumbnail)-->
		<xsl:if test="normalize-space($THUMB_URI) != ''">
			<xsl:call-template name="ECRM_E38">
				<xsl:with-param name="URI" select="normalize-space($THUMB_URI)"/>
				<xsl:with-param name="LBL" select="normalize-space($THUMB_LABEL)"/>
			</xsl:call-template>	
			
			<xsl:call-template name="ECRM_X_P2_Y">
				<xsl:with-param name="X_URI" select="normalize-space($THUMB_URI)"/>
				<xsl:with-param name="Y_URI" select="'&claros;Thumbnail'"/>
			</xsl:call-template>

			<xsl:call-template name="ECRM_X_P138_Y">
				<xsl:with-param name="X_URI" select="normalize-space($THUMB_URI)"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_URI)"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Man-Made_Object has_representation Image-->
		<xsl:if test="normalize-space($IMAGE_URI) != ''">
			<xsl:call-template name="ECRM_E38">
				<xsl:with-param name="URI" select="normalize-space($IMAGE_URI)"/>
				<xsl:with-param name="LBL" select="normalize-space($IMAGE_LABEL)"/>
			</xsl:call-template>

			<xsl:call-template name="ECRM_X_P138_Y">
				<xsl:with-param name="X_URI" select="normalize-space($IMAGE_URI)"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_URI)"/>
			</xsl:call-template>
		</xsl:if>
		
		<!--Man-Made_Object is_documented_in URI-->
		<xsl:if test="normalize-space($PAGE_URI) != ''">
			<xsl:call-template name="ECRM_X_P70_Y">
				<xsl:with-param name="X_URI" select="normalize-space($PAGE_URI)"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_URI)"/>
			</xsl:call-template>
		</xsl:if>	
		
		<!--Man-Made_Object is_referred_to_by URI-->
		<xsl:if test="normalize-space($REFERENCE) != ''">
			<xsl:call-template name="ECRM_X_P67_Y">
				<xsl:with-param name="X_URI" select="normalize-space($REFERENCE)"/>
				<xsl:with-param name="Y_URI" select="normalize-space($OBJECT_URI)"/>
			</xsl:call-template>
		</xsl:if>
		
	</xsl:template>	<!--end CLAROS_OBJECT-->
	
	<!--CLAROS_PLACE-->
	<xsl:template name="CLAROS_PLACE">
		<xsl:param name="PLACE_URI" select="''"/>
		<xsl:param name="LABEL" select="''"/>
		<xsl:param name="PLACE_NAME_URI" select="''"/>
		<xsl:param name="PLACE_NAME" select="''"/>
		<xsl:param name="LATITUDE_DEGREES" select="''"/>
		<xsl:param name="LONGITUDE_DEGREES" select="''"/>

		<!--Create the Place entity-->
		<xsl:call-template name="ECRM_E53">
			<xsl:with-param name="URI" select="$PLACE_URI"/>
			<xsl:with-param name="LBL" select="$LABEL"/>
		</xsl:call-template>
		
		<!--Place is_identified_by PlaceName-->
		<xsl:if test="normalize-space($PLACE_NAME) != ''">
			<xsl:call-template name="ECRM_X_P87_Y">
				<xsl:with-param name="X_URI" select="$PLACE_URI"/>
				<xsl:with-param name="Y_OBJ">
					<xsl:call-template name="ECRM_E48">
						<xsl:with-param name="URI" select="$PLACE_NAME_URI"/>
						<xsl:with-param name="VAL" select="$PLACE_NAME"/>
					</xsl:call-template>
				</xsl:with-param>	
			</xsl:call-template>
		</xsl:if>

		<!--Place is_identified_by Location-->
		<xsl:if test="normalize-space($LATITUDE_DEGREES) != ''">
			<xsl:if test="normalize-space($LONGITUDE_DEGREES) != ''">
				<xsl:call-template name="ECRM_X_P87_Y">
					<xsl:with-param name="X_URI" select="$PLACE_URI"/>
					<xsl:with-param name="Y_OBJ">
						<ecrm:E47_Spatial_Coordinates>
					      <claros:has_geoObject>
					        <geo:Point>
					          <geo:lat><xsl:value-of select="$LATITUDE_DEGREES"></xsl:value-of></geo:lat>
					          <geo:long><xsl:value-of select="$LONGITUDE_DEGREES"></xsl:value-of></geo:long>
					        </geo:Point>
					      </claros:has_geoObject>
	    				</ecrm:E47_Spatial_Coordinates>
					</xsl:with-param>	
				</xsl:call-template>
			</xsl:if>
		</xsl:if>
		
	</xsl:template> <!--end CLAROS_PLACE-->

	<!--CLAROS_PERSON-->
	<xsl:template name="CLAROS_PERSON">
		<xsl:param name="PERSON_URI" select="''"/>
		<xsl:param name="LABEL" select="''"/>
		<xsl:param name="PERSON_NAME_URI" select="''"/>
		<xsl:param name="PERSON_NAME" select="''"/>
		
		<!--Create the Person entity-->
		<xsl:call-template name="ECRM_E21">
			<xsl:with-param name="URI" select="$PERSON_URI"/>
			<xsl:with-param name="LBL" select="$LABEL"/>
		</xsl:call-template>		
		
		<!--Person is_identified_by ActorAppellation-->
		<xsl:if test="normalize-space($PERSON_NAME) != ''">
			<xsl:call-template name="ECRM_X_P131_Y">
				<xsl:with-param name="X_URI" select="$PERSON_URI"/>
				<xsl:with-param name="Y_OBJ">
					<xsl:call-template name="ECRM_E82">
						<xsl:with-param name="URI" select="$PERSON_NAME_URI"/>
						<xsl:with-param name="VAL" select="$PERSON_NAME"/>
					</xsl:call-template>
				</xsl:with-param>	
			</xsl:call-template>
		</xsl:if>	
		
	</xsl:template> <!--end CLAROS_PERSON-->

</xsl:stylesheet>
