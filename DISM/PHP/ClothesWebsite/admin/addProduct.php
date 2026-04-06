<?php 
include("config.php");
include("header.php");

$sel = "SELECT * FROM category";
$query = mysqli_query($conn, $sel);
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

                                <select name="ci" required class="form-select mb-3">
                                <option disabled selected>Select Category</option>
                                <?php while($data = mysqli_fetch_array($query)){ ?>
                                <option value="<?php echo $data[0] ?>"> <?php echo $data[1] ?></option>
                                <?php } ?>
                            </select>
                                
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
        $ci = $_POST["ci"]; //
        $pi = $_FILES["pi"];

        $imgname = $pi["name"];
        $imgtmpname = $pi["tmp_name"];

        // echo $pn;
        // echo $pp;
        // echo $pd;
        // echo print_r($pi);

        $folder = "upload/" . $imgname;

        if(is_uploaded_file($imgtmpname)){
            move_uploaded_file($imgtmpname, $folder);

            $ins = "INSERT INTO product (product_name, product_price, product_description, category_id, product_image)
             VALUES ('$pn', '$pp', '$pd', '$ci', '$imgname')";
     
             $query = mysqli_query($conn, $ins);
     
             if($query){
                 echo "Record Inserted!";
                 "<script>
                 window.location.href = 'viewProduct.php';
                 </script>";
             }
        }   
    }

include("footer.php");
?>