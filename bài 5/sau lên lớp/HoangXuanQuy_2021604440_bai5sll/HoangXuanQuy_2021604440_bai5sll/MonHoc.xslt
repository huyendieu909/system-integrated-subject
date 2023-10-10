<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:a="http://tempuri.org/XMLSchema.xsd"
>
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <head>
        <title>Bài thực hành 1</title>
      </head>
      <body>
        <h2>Truy vấn môn học có số giờ từ 40 trở lên</h2>
        <table border="1" cellpadding="10px">
          <tr>
            <th align="left" width="100px">MaMh</th>
            <th align="left" width="400px">TenMh</th>
            <th align="left" width="100px">SoGio</th>
          </tr>
          <xsl:for-each select="a:DS/a:MonHoc[a:SoGio &gt;= 40]">
            <tr>
              <td>
                <xsl:value-of select="@MaMh"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="a:TenMh"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="a:SoGio"></xsl:value-of>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
