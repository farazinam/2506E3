<?php
  $conn = mysqli_connect("localhost", "root", "", "clothes");

  $getId = $_GET["id"];
  //echo($getId);

  $select =  "SELECT * FROM category WHERE category_id = '$getId'";
  $query = mysqli_query($conn, $select);


?>