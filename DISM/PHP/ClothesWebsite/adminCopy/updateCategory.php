<?php 
include("config.php");
include("header.php");

  $getId = $_GET["id"];
  //echo($getId);

  $select =  "SELECT * FROM category WHERE category_id = '$getId'";
  $query = mysqli_query($conn, $select);

  $data = mysqli_fetch_array($query);
  // echo $data[0];
  // echo $data[1];
?>

            <!-- Form Start -->
            <div class="container-fluid pt-4 px-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-xl-6">
                        <div class="bg-light rounded h-100 p-4">
                            <h6 class="mb-4">Category</h6>
                            <form method="POST">
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Edit Category</label>
                                    <input type="text" name="category" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" value="<?php echo $data[1] ?>">
                                </div>
                                <button type="submit" name="updatecat" class="btn btn-primary">Edit Category</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Form End -->

<?php 
 if(ISSET($_POST["updatecat"])){
     $cat = $_POST["category"];
    $update = "UPDATE category SET category_name = '$cat' WHERE category_id = '$getId'";
    $query = mysqli_query($conn, $update);

    if($query){
            echo "Record Updated!";
        }
   }

include("footer.php");
?>