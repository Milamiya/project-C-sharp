<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does display a table
        for modifing a staff.
    -->
    <xsl:template name="doStaff">
        <xsl:for-each select="//nhanvien">
            <xsl:variable name="staffid">
                <xsl:value-of select="manv" />
            </xsl:variable>
            <tr>
                <td><font face="VNI-Times"><xsl:value-of select="@stt" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="manv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="tennv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="magroup" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="ngaysinh" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="diachi" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="phone" /></font></td>
                <td><a href="prepareStaff.jsp?staffid={$staffid}"><font face="VNI-Times">S��a</font></a></td>
            </tr>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Ma� NV</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n NV</font></th>
                <th><font face="VNI-Times" color="#003366">Thuo�c Nho�m</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y Sinh</font></th>
                <th><font face="VNI-Times" color="#003366">��a Ch�</font></th>
                <th><font face="VNI-Times" color="#003366">�ie�n Thoa�i</font></th>
                <th><font face="VNI-Times" color="#003366">&#160;&#160;&#160;</font></th>
            </tr>
            <xsl:call-template name="doStaff" />
        </table>
    </xsl:template>
</xsl:stylesheet>