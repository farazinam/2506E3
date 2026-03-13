<?php
  $conn = mysqli_connect("localhost", "root", "", "clothes");

  $getId = $_GET["id"];
  //echo($getId);

  $select =  "SELECT * FROM category WHERE category_id = '$getId'";
  $query = mysqli_query($conn, $select);

  $data = mysqli_fetch_array($query);
  // echo $data[0];
  // echo $data[1];
?>

  <form action="" method="POST">
        <label for="">Category Name</label>
        <input type="text" name="category" value="<?php echo $data[1] ?>">
        <button type="submit" name="updcat">Update Category</button>
    </form>

    <?php
     if(ISSET($_POST["updcat"])){
     $cat = $_POST["category"];
    $update = "UPDATE category SET category_name = '$cat' WHERE category_id = '$getId'";
    $query = mysqli_query($conn, $update);

    if($query){
            echo "Record Updated!";
        }
   }
    
    ?>