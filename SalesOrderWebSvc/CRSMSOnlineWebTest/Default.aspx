<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRSMSOnlineWebTest._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.:CRSMS:.</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="MainContainer" style="background:white;">
        <br/>
        <div id ="SubContainer" style="max-height:590px;overflow-y:scroll;">   
	    <fieldset style="margin:auto;background:white;width:95.8%;height: 93%;padding-top:1%;">
	    <legend style="padding:10px;background:#7b1113;color:white;font-size:2.5em;">
	    Celing's RTW Sales Management System</legend>
	    
		<div id="Info" style="margin:auto;width:50%;">
		    <fieldset>
		    <legend style="padding:10px;background:#7b1113;color:white;">INFO</legend>
	    
	            <table style="margin:auto">
		            
                    <tr>
			            <td><label for="studno">First Name: </label></td>
			            <td> <input type="text" title="4 characters minimum" name="fname" id="fname"/></td>
		            </tr>
		            
		            <tr>
			            <td><label for="name">Last Name: </label></td>
			            <td> <input type="text" name="lname" id="lname" title="4 characters minimum"/></td>
		            </tr>
		            <tr>
			            <td><label for="section">Address: </label></td>
			            <td> <textarea name="address" id="address" rows="3" title="20 characters minimum"></textarea></td>
		            </tr>
		            <tr>
			            <td><label for="course">Contact No.: </label></td>
			            <td> <input type="text" name="contactno" id="contactno" /></td>
		            </tr>
		            
		            <tr>
			            <td></td>
			            <td><input type="submit" value="SAVE" id="save" name="save" style="width: 100%;"/></td>
		            </tr>
		            
                    <tr>
			            <td></td>
			            <td><input type="button" value="CLEAR / REFRESH" onclick="window.location.href='Default.aspx';" style="width: 100%;"/></td>
		            </tr>

	            </table>
                    <input type="hidden" value="" id="toDelete" name="toDelete"/>
                
                </fieldset>
            </div>
            
	        </fieldset>
        </div><br/>
	</div>
    </form>
</body>
</html>
