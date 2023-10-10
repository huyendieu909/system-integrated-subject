<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:a="http://tempuri.org/XMLSchema.xsd">
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <head>
        <title>bai2</title>
      </head>
      <body>
        <table border="1" cellpadding="10px">
          <tr>
            <th>STT</th>
            <th>MaSv</th>
            <th width="100px">TenSv</th>
            <th>GioiTinh</th>
            <th>NgaySinh</th>
            <th>MaLop</th>
          </tr>
          <xsl:for-each select="a:DS/a:SinhVien">
            <tr>
              <td>
                <xsl:number value="position()"/>
              </td>
              <td>
                <xsl:value-of select="@MaSv"/>
              </td>
              <td>
                <xsl:value-of select="a:TenSv"/>
              </td>
              <td>
                <xsl:value-of select="a:GioiTinh"/>
              </td>
              <td>
                <xsl:value-of select="a:NgaySinh"/>
              </td>
              <td>
                <xsl:value-of select="a:MaLop"/>
              </td>
            </tr>
          </xsl:for-each>

          <!--<xsl:apply-templates select="SinhVien"></xsl:apply-templates>-->
        </table>
      </body>
    </html>
  </xsl:template>

  <!--<xsl:template match="SinhVien">
    <tr>
      <td>
        <xsl:number value="position()"/>
      </td>
      <td>
        <xsl:value-of select="@MaSv"/>
      </td>
      <td>
        <xsl:value-of select="TenSv"/>
      </td>
      <td>
        <xsl:value-of select="GioiTinh"/>
      </td>
      <td>
        <xsl:value-of select="NgaySinh"/>
      </td>
      <td>
        <xsl:value-of select="MaLop"/>
      </td>
    </tr>
  </xsl:template>-->
</xsl:stylesheet>
