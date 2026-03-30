<?php
  include("config.php");

  $getId = $_GET["id"];
  //echo($getId);

  $delete = "DELETE FROM product WHERE product_id = '$getId'";
  $query = mysqli_query($conn, $delete);

    if($query){
            echo "<script>
            alert('Record Deleted');
            window.location.href = 'viewProduct.php';
            </script>";
        }
?>