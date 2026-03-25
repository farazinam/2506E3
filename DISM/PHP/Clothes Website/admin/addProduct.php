<?php 
include("config.php");
include("header.php");
?>

            <!-- Form Start -->
            <div class="container-fluid pt-4 px-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-xl-6">
                        <div class="bg-light rounded h-100 p-4">
                            <h6 class="mb-4">Product</h6>
                            <form method="POST" enctype="multipart/form-data">
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Name</label>
                                    <input type="text" name="pn" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Name">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Price</label>
                                    <input type="number" name="pp" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Price">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Description</label>
                                    <input type="text" name="pd" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Description">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Image</label>
                                    <input type="file" name="pi" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp">
                                </div>
                                <button type="submit" name="addpro" class="btn btn-primary">Add Product</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Form End -->

<?php 
if(ISSET($_POST["addpro"])){
        $pn = $_POST["pn"];
        $pp = $_POST["pp"];
        $pd = $_POST["pd"];
        $pi = $_FILES["pi"];

        $imgname = $pi["name"];
        $imgtmpname = $pi["tmp_name"];

        // echo $pn;
        // echo $pp;
        // echo $pd;
        // echo print_r($pi);
        
       $ins = "INSERT INTO product (product_name, product_price, product_description, product_image)
        VALUES ('$pn', '$pp', '$pd', '$imgname')";

        $query = mysqli_query($conn, $ins);

        if($query){
            echo "Record Inserted!";
        }
    }

include("footer.php");
?>