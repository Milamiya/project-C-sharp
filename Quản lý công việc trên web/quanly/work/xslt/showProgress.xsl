<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing Progress.
    -->
    <xsl:template name="doProgress">
        <xsl:param name="num" select="1" />
        <xsl:choose>
            <xsl:when test="$num=1">
                <td width="87" height="19" align="center"><font face="VNI-Times"><xsl:value-of select="./baocaongay/@ngay" /></font></td>
                <td width="40" height="19" align="center"><font face="VNI-Times"><xsl:value-of select="./baocaongay/@tiendo" />%</font></td>
                <td width="200" height="19"><font face="VNI-Times"><xsl:value-of select="./baocaongay/@ghichu" /></font></td>
            </xsl:when>
            <xsl:otherwise><!--xsl:when test="$num>1"-->
                <!-- (chi lay 1)./baocaongay != //baocaongay(lay tat ca) -->
                <xsl:for-each select="./baocaongay">
                    <xsl:if test="./@id > 1">
                        <tr>
                            <td width="87" height="19" align="center"><font face="VNI-Times"><xsl:value-of select="./@ngay" /></font></td>
                            <td width="40" height="19" align="center"><font face="VNI-Times"><xsl:value-of select="./@tiendo" />%</font></td>
                            <td width="200" height="19"><font face="VNI-Times"><xsl:value-of select="./@ghichu" /></font></td>
                        </tr>
                    </xsl:if>
                </xsl:for-each>
            </xsl:otherwise><!--/xsl:when-->
        </xsl:choose>
    </xsl:template>

    <xsl:template match="congviec"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th width="190" height="19"><font face="VNI-Times" color="#003366">Teân Coâng Vieäc</font></th>
                <th width="87" height="19"><font face="VNI-Times" color="#003366">Ngaøy</font></th>
                <th width="60" height="19"><font face="VNI-Times" color="#003366">Tieán Ñoä</font></th>
                <th width="200" height="19"><font face="VNI-Times" color="#003366">Ghi Chuù</font></th>
            </tr>
            <xsl:for-each select="works">
                <xsl:variable name="rows">
                    <xsl:value-of  select="./report-row/@no" />
                </xsl:variable>
                <tr>
                    <td width="190" height="19" rowspan="{$rows}">
                        <font face="VNI-Times">
                            <xsl:number value="position()" format="1. " />
                            <xsl:apply-templates select="./@name" />
                        </font>
                    </td>
                    <xsl:call-template name="doProgress">
                        <xsl:with-param name="num" select="1" />
                    </xsl:call-template>
                </tr>
                <xsl:if test="./baocaongay/@id > 1">
                    <xsl:call-template name="doProgress">
                        <xsl:with-param name="num" select="3" />
                    </xsl:call-template>
                </xsl:if>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>