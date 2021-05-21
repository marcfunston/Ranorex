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
?>

<html>
<title>Ranorex Flashcards</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<body>
<p>Running</p>
<?php
$matches = array();
  if(substr($key, 0, 9) == 'logged_in') {
    $matches[] = $key;
  }
?>
<p>Done</p>
</body>
</html>