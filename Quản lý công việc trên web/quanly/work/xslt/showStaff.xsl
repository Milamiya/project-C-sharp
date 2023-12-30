<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing permissions.
    -->
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Ma� NV</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n NV</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y Sinh</font></th>
                <th><font face="VNI-Times" color="#003366">��a Ch�</font></th>
                <th><font face="VNI-Times" color="#003366">�ie�n Thoa�i</font></th>
                <th><font face="VNI-Times" color="#003366">Thuo�c Nho�m</font></th>
            </tr>
            <xsl:for-each select="//nhanvien">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./manv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tennv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaysinh" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./diachi" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./phone" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tengroup" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>