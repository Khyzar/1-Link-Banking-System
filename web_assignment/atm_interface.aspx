<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="atm_interface.aspx.cs" Inherits="web_assignment.atm_interface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<title>Rohaani Bank</title>
<link href='http://fonts.googleapis.com/css?family=Droid+Sans' rel='stylesheet' type='text/css'>
<link href="style.css" rel="stylesheet" type="text/css" media="all" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
<!-- -->
<script>var __links = document.querySelectorAll('a'); function __linkClick(e) { parent.window.postMessage(this.href, '*'); }; for (var i = 0, l = __links.length; i < l; i++) { if (__links[i].getAttribute('data-t') == '_blank') { __links[i].addEventListener('click', __linkClick, false); } }</script>
<script src="jquery-1.11.1.min.js"></script>
<script>$(document).ready(function (c) {
    $('.alert-close').on('click', function (c) {
        $('.message').fadeOut('slow', function (c) {
            $('.message').remove();
        });
    });
  
    $("#1").click(function () {
        $("#2").hide();
        $("#3").hide();
        $("#4").hide();
        $("#1").hide();
        $("#5").hide();
        $("#tm").show();
        //$("#Button1").show();
    });
    $("#2").click(function () {
        $("#2").hide();
        $("#3").hide();
        $("#4").hide();
        $("#1").hide();
        $("#5").hide();
        $("#cb").show();
        //$("#Button1").show();
    });
    
    $("#3").click(function () {
        $("#2").hide();
        $("#3").hide();
        $("#4").hide();
        $("#1").hide();
        $("#5").hide();
        $("#d").show();
        //$("#Button1").show();
    });

    $("#4").click(function () {
        $("#2").hide();
        $("#3").hide();
        $("#4").hide();
        $("#1").hide();
        $("#5").hide();
        $("#w").show();
        //$("#Button1").show();
    });



    $("#Button1_b").click(function () {
        $("#tm").hide();
        $("#cb").hide();
        $("#d").hide();
        $("#w").hide();
        //$("#Button1_b").hide();

        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });
    
    $("#Button2_b").click(function () {
        $("#tm").hide();
        $("#cb").hide();
        $("#d").hide();
        $("#w").hide();
      //  $("#Button1").hide();

        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });

    $("#Button3_b").click(function () {
        $("#tm").hide();
        $("#cb").hide();
        $("#d").hide();
        $("#w").hide();
        //$("#Button1").hide();

        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });

    $("#Button4_b").click(function () {
        $("#tm").hide();
        $("#cb").hide();
        $("#d").hide();
        $("#w").hide();
        //$("#Button1").hide();

        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });



    $("#Button1_e").click(function () {
        $("#tm").hide();
        $("#after_tm").show();
        
        
    });
    $("#Button3_e").click(function () {
        $("#d").hide();
        $("#after_d").show();

        
    });
    
    $("#Button4_e").click(function () {
        $("#w").hide();
        $("#after_w").show();
        
    });

    $("#Button1_m_tm").click(function () {
        $("#after_tm").hide();
        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });

    $("#Button2_m_d").click(function () {
        $("#after_d").hide();
        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });

    $("#Button3_m_w").click(function () {
        $("#after_w").hide();
        $("#1").show();
        $("#2").show();
        $("#3").show();
        $("#4").show();
        $("#5").show();

    });

});
</script>

</head>
<body>
   <div class="message warning">
<div class="inset">
	<div class="login-head">
		<h1>Rohaani Bank</h1>
		 <div class="alert-close"> </div> 			
	</div>
    <div class="mid_content" >
       
                  <button type="button"  id="1"  class="butt1_pos inputtext _58mg color_class" ><h10>Transfer Money</h10></button>
        <button type="button"  id="2"  class="butt2_pos _58mg inputtext color_class" > <h10>Check Balance</h10></button>
        <button type="button"  id="3"  class="butt3_pos _58mg inputtext color_class" ><h10>Deposit Money</h10></button>
        <button type="button" id="4"  class="butt4_pos _58mg inputtext color_class" ><h10>Withdrawal Money</h10></button>

       <button type="button" id="5"  class="butt5_pos _58mg inputtext color_class" ><a href="login.aspx"  ><h10>Log out</h10></a></button>


        <div id="tm" class="display_">
            <br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp
            <input type="text"   id="acc_no"   class="_58mg inputtext box_length marginbox text_box_font"   placeholder="  Enter Account no" value=""/>
            <br /><br />&nbsp&nbsp&nbsp&nbsp
             <input type="text"   id="t_money"   class="_58mg inputtext box_length marginbox text_box_font" placeholder="  Enter Amount" value=""/>
         <button type="button" id="Button1_b"  class="back_tm_pos _58mg inputtext color_class" ><h10>Back</h10></button>
            <button type="button" id="Button1_e"  class="enter_tm_pos _58mg inputtext color_class" ><h10>Enter</h10></button>
              <button type="button" id="Button1"  class="l_tm _58mg inputtext color_class" ><a href="login.aspx"  ><h10>Log out</h10></a></button>
               </div>
        <div id="cb" class="display_">
            <br /><br />
         <h style="color:black">Your balance is </h> <br /><br /> &nbsp&nbsp&nbsp&nbsp&nbsp<input type="text"   id="dis_money"   class="_58mg inputtext box_length marginbox text_box_font" placeholder=" balance " value=""/>           
         <button type="button" id="Button2_b"  class="back_cb_pos _58mg inputtext color_class" ><h10>Back</h10></button>
        <button type="button" id="Button2"  class="l_cb _58mg inputtext color_class" ><a href="login.aspx"  ><h10>Log out</h10></a></button>
        </div>
        <div id="d" class="display_">
              <br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp
             <input type="text"   id="d_money"   class="_58mg inputtext box_length marginbox text_box_font" placeholder="  Enter Amount" value=""/>
            <button type="button" id="Button3_b"  class="back_d_pos _58mg inputtext color_class" ><h10>Back</h10></button>
       <button type="button" id="Button3_e"  class="enter_d_pos _58mg inputtext color_class" ><h10>Enter</h10></button>
        <button type="button" id="Button3"  class="l_d _58mg inputtext color_class" ><a href="login.aspx"  ><h10>Log out</h10></a></button>
        </div>
        <div id="w" class="display_">
             <br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp
             <input type="text"   id="w_money"   class="_58mg inputtext box_length marginbox text_box_font" placeholder="  Enter Amount" value=""/>
            <button type="button" id="Button4_b"  class="back_w_pos _58mg inputtext color_class" ><h10>Back</h10></button>
               <button type="button" id="Button4_e"  class="enter_w_pos _58mg inputtext color_class" ><h10>Enter</h10></button>
        <button type="button" id="Button4"  class="l_w _58mg inputtext color_class" ><a href="login.aspx"  ><h10>Log out</h10></a></button>
        </div>
        <div id="after_tm" class="display_">
            <br /><br />
            <h1 style="color:black">Your money has been transfered </h1>
            <button type="button" id="Button1_m_tm"  class="enter_m_tm _58mg inputtext color_class" ><h10>Menu</h10></button>
            <button type="button" id="Button7"  class="enter_l_tm _58mg inputtext color_class" ><a href="login.aspx"><h10>Log out</h10></a></button>
        </div>
        <div id="after_d"  class="display_">
            <br /><br />
            <h1 style="color:black">Your money has been deposited </h1>
            <button type="button" id="Button2_m_d"  class="enter_m_tm _58mg inputtext color_class" ><h10>Menu</h10></button>
            <button type="button" id="Button6"  class="enter_l_tm _58mg inputtext color_class" ><a href="login.aspx"><h10>Log out</h10></a></button>

        </div>
        <div id="after_w" class="display_">
            <br /><br />
            <h1 style="color:black">Money withdrawal done </h1>
            <button type="button" id="Button3_m_w"  class="enter_m_tm _58mg inputtext color_class" ><h10>Menu</h10></button>
            <button type="button" id="Button5"  class="enter_l_tm _58mg inputtext color_class" ><a href="login.aspx"><h10>Log out</h10></a></button>

        </div>

    </div>
    </div>
       </div>

</body>
</html>
