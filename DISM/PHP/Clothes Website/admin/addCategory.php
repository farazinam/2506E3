<?php 
include("config.php");
include("header.php");
?>

            <!-- Form Start -->
            <div class="container-fluid pt-4 px-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-xl-6">
                        <div class="bg-light rounded h-100 p-4">
                            <h6 class="mb-4">Category</h6>
                            <form method="POST">
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Add Category</label>
                                    <input type="text" name="category" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp">
                                </div>
                                <button type="submit" name="addcat" class="btn btn-primary">Add Category</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Form End -->

<?php 
if(ISSET($_POST["addcat"])){
        $cat = $_POST["category"];
        
       $ins = "INSERT INTO category (category_name)
        VALUES ('$cat')";

        $query = mysqli_query($conn, $ins);

        if($query){
            echo "Record Inserted!";
        }
    }

include("footer.php");
?>