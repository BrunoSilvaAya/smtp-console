public static class Template
{
    public static string template = @"
    
<!--  CSS   -->
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title></title>
    <style>
        /* Remove space around the email design. */
        html,
        body {
            margin: 0 auto !important;
            padding: 0 !important;
            height: 100% !important;
            width: 100% !important;
        }
        /* Stop Outlook resizing small text. */
        * {
            -ms-text-size-adjust: 100%;
        }
        /* Stop Outlook from adding extra spacing to tables. */
        table,
        td {
            mso-table-lspace: 0pt !important;
            mso-table-rspace: 0pt !important;
        }
        /* Use a better rendering method when resizing images 
        in Outlook IE. */
        img {
            -ms-interpolation-mode:bicubic;
        }
        /* Prevent Windows 10 Mail from underlining links. 
        Styles for underlined links should be inline. */
        a {
            text-decoration: none;
        }
        .header {
            max-width: 600px;
            background-color: #FCFAF7;
            padding: 24px;
            text-align: center;
            margin: 0 auto;
        }
        .logo {
            max-width: 100%;
            height: 32px;
            width: auto;
        }
    <!-- Header -->
        <!--- Logo  ---->

    <!--- Body --->
        <!--- Subject --->
        <!--- Desciption --->
        <!--  Table -->
        <!--  Button  -->
    <!-- Footer  -->
        <!-- Questions text  -->
        <!-- Automated notfication  -->
        <!-- Copyright  -->
    </style>
</head>
<body>
<!-- Header -->
    <div class='header'>
    <img src='cid:logo' alt='Lotus One' class='logo' />
    </div>
   <!--- Logo (Lotus One or Lotus One/Shifts) -->

<!--- Body --->
  <!--- Subject ---><span><strong>SUBJECT</strong></span><br/>
  <!--- Desciption (optional) ---><span>description</span><br/>
  <!--  Table Data (dynamically generated) -->
  <!--  Button(s) (dynamically generated)  --><span>button</span><br/>

<!-- Footer  -->
   <!-- Questions text (optional) -->
   <!-- Automated notfication (static) -->
   <!-- Copyright (static) -->
</body>
</html>


    ";

    public static string templateSplit = @"
    
    <!--  CSS   -->
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title></title>
    <style>
        /* Remove space around the email design. */
        html,
        body {
            margin: 0 auto !important;
            padding: 0 !important;
            height: 100% !important;
            width: 100% !important;
        }
        /* Stop Outlook resizing small text. */
        * {
            -ms-text-size-adjust: 100%;
        }
        /* Stop Outlook from adding extra spacing to tables. */
        table,
        td {
            mso-table-lspace: 0pt !important;
            mso-table-rspace: 0pt !important;
        }
        /* Use a better rendering method when resizing images 
        in Outlook IE. */
        img {
            -ms-interpolation-mode:bicubic;
        }
        /* Prevent Windows 10 Mail from underlining links. 
        Styles for underlined links should be inline. */
        a {
            text-decoration: none;
        }
        .header {
            max-width: 600px;
            background-color: #FCFAF7;
            padding: 24px;
            text-align: center;
            margin: 0 auto;
        }
        .divider {
            width: 5px;
            background-color: #000;
        }
    <!-- Header -->
        <!--- Logo  ---->

    <!--- Body --->
        <!--- Subject --->
        <!--- Desciption --->
        <!--  Table -->
        <!--  Button  -->
    <!-- Footer  -->
        <!-- Questions text  -->
        <!-- Automated notfication  -->
        <!-- Copyright  -->
    </style>
</head>
<body>
<!-- Header -->
    <div class='header'>
    <table width='100%' cellpadding='0' cellspacing='0' border='0'>
        <tr>
            <td align='center' valign='middle' width='48%'>
                <img src='cid:logo1' alt='Lotus One'style='max-width: 100%; height: auto;' />
            </td>
            <td width='4%' align='center' valign='middle'>
                <div class='divider' style='height: 100%;'></div>
            </td>
            <td align='center' valign='middle' width='48%'>
                <img src='cid:logo2' alt='Shifts' style='max-width: 100%; height: auto;' />
            </td>
        </tr>
    </table>
    </div>
   <!--- Logo (Lotus One or Lotus One/Shifts) -->

<!--- Body --->
  <!--- Subject ---><span><strong>SUBJECT</strong></span><br/>
  <!--- Desciption (optional) ---><span>description</span><br/>
  <!--  Table Data (dynamically generated) -->
  <!--  Button(s) (dynamically generated)  --><span>button</span><br/>

<!-- Footer  -->
   <!-- Questions text (optional) -->
   <!-- Automated notfication (static) -->
   <!-- Copyright (static) -->
</body>
</html>
    
    ";
}