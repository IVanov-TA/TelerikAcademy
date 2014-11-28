<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students DB</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Student Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birth Day</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>E-mail</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Specialty</b>
            </td>
            <td>
              <b>Faculty Number</b>
            </td>
            <td>
              <b>Exams</b>
            </td>
            <td>
              <b>Enrolment</b>
            </td>
            <td>
              <b>Teacher Endorsment</b>
            </td>
          </tr>
          <xsl:for-each select="studentDb/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthDay"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="fn"/>
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <tr>
                    <td>
                      <xsl:value-of select="name"/>
                    </td>
                    <td>
                      <xsl:value-of select="tutor"/>
                    </td>
                    <td>
                      <xsl:value-of select="score"/>
                    </td>
                  </tr>
                </xsl:for-each>
              </td>
              <td>
                <xsl:for-each select="enrolment">
                  <tr>
                    <td>
                     enrolment: <xsl:value-of select="date"/>
                    </td>
                    <td>
                      |
                    </td>
                    <td>
                      <xsl:value-of select="score"/> points
                    </td>
                  </tr>
                </xsl:for-each>
              </td>
              <td>
                <xsl:for-each select="teacherEndorsments">
                  <tr>
                    <td>
                      <xsl:value-of select="endorsment"/>
                    </td>
                  </tr>
                </xsl:for-each>
              </td>
              </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>