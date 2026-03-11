<?php
  $conn = mysqli_connect("localhost", "root", "", "clothes");

  $getId = $_GET["id"];
  //echo($getId);

  $delete = "DELETE FROM category WHERE category_id = '$getId'";
  $query = mysqli_query($conn, $delete);

    if($query){
            echo "Record Deleted!";
        }
?>