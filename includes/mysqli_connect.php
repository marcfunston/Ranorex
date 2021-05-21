<?php
/*
 * Title: Ranorex Flashcards 
 * Author: Marc Funston
 * Purpose: This page contains the top part of the html. 
 * Bugs: None known at this time
 * Last Edit Date: 5/21/2021 Intital Commit
 *                  HTML cleaned up from other builds
 * 
 */

DEFINE ('DB_USER', 'root');
DEFINE ('DB_PASSWORD', '');
DEFINE ('DB_HOST', 'localhost');
DEFINE ('DB_NAME', 'ranorex');


// make the connection:
$dbc = @mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME) OR die ('Could not connect to MYSQL: ' . mysqli_connect_error());

// Set the encoding
mysqli_set_charset($dbc, 'utf8');


?>