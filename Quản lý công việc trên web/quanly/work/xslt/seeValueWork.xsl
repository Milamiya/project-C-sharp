<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing Work Value.
    -->
    <xsl:template match="congviec"> <!-- Root document: congviec -->
        <table border="1" width="100%" align="center">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Teân CV</font></th>
                <th><font face="VNI-Times" color="#003366">Ñaùnh Giaù</font></th>
                <th><font face="VNI-Times" color="#003366">Chuù Thích</font></th>
                <th><font face="VNI-Times" color="#003366">Phaûn Hoài</font></th>
            </tr>
            <xsl:for-each select="works">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tencv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./xeploai" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./chuthich" /></font></td>
                    <td>
                        <font face="VNI-Times">
                        <xsl:choose>
                            <xsl:when test="./phanhoi='null'">
                                <xsl:variable name="valueId" select="./madg" />
                                <input type="hidden" name="id" value="{$valueId}" />
                                <input type="text" name="feedback" onchange="testSubmit(this.form)" />
                            </xsl:when>
                            <xsl:otherwise>
                                <xsl:apply-templates select="./phanhoi" />
                            </xsl:otherwise>
                        </xsl:choose>
                        </font>
                    </td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>