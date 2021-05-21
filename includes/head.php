<?php
/*
 * Title: Ranorex Flashcards Head Page
 * Author: Marc Funston
 * Purpose: This page contains the top part of the html. 
 * Bugs: None known at this time
 * Last Edit Date: 5/21/2021 Intital Commit
 *                  HTML cleaned up from other builds
 * 
 */
?>
<!DOCTYPE html>
<html>
<title>Ranorex</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="style/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<style>
body,
h1,
h2,
h3,
h4,
h5 {
    font-family: "Raleway", sans-serif
}
</style>
<head>
  <script>
    function myFunction() {var x = document.getElementById("DEMO"); var y = document.getElementById("DEMO2");
        if (x.className.indexOf("w3-show") == -1) {x.className += " w3-show"; y.className += " w3-hide";
        } else {x.className = x.className.replace(" w3-show", ""); y.className = y.className.replace(" w3-hide", "");}}
    function w3_open() {document.getElementById("mySidebar").style.display = "block";}
    function w3_close() {document.getElementById("mySidebar").style.display = "none";}
  </script>
</head>
<?php  
if (!isset($_COOKIE['page'])) {
    setcookie ('page', 1);	
  } else { 
    $page = $_COOKIE['page'];
  }
?>
<body class="w3-light-grey">
  <div class="w3-content" style="max-width:1000px">
    <header class="w3-container w3-center w3-padding-32">
        <div class="w3-row">
            <div>
                <h1><b>Ranorex Flashcards</b></h1>
                <h2><b>Knowledge</b></h2>
                <h3 class="w3-tag">The Gateway to a Bigger World!</h3>
            </div>
        </div>
    </header>
    <div class="w3-row">
      <div class="w3-col l8 s12">