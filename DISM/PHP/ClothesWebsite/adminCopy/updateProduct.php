<?php 
include("config.php");
include("header.php");

  $getId = $_GET["id"];

$select = "SELECT * FROM product WHERE product_id = '$getId'";
$query = mysqli_query($conn, $select);

$data = mysqli_fetch_array($query);
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
                                    <input type="text" name="pn" value="<?php echo $data[1] ?>" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Name">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Price</label>
                                    <input type="number" name="pp" value="<?php echo $data[2] ?>" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Price">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Description</label>
                                    <input type="text" name="pd" value="<?php echo $data[3] ?>" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp" placeholder="Product Description">
                                </div>
                                <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">Product Image</label>
                                    <input type="file" name="pi" class="form-control" id="exampleInputEmail1"
                                        aria-describedby="emailHelp">
                                </div>
                                <button type="submit" name="updatepro" class="btn btn-primary">Update Product</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Form End -->

<?php 
if(ISSET($_POST["updatepro"])){
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

        $folder = "upload/" . $imgname;

        if(is_uploaded_file($imgtmpname)){
            move_uploaded_file($imgtmpname, $folder);

            $upd = "UPDATE `product` 
            SET `product_name`='$pn',`product_price`='$pp',`product_description`='$pd',`product_image`='$imgname' 
            WHERE product_id = '$getId'";
     
             $query = mysqli_query($conn, $upd);
     
             if($query){
                echo "<script>
            alert('product Updated');
            window.location.href = 'viewProduct.php';
            </script>";
             }
        }
        
        else{
            $upd = "UPDATE `product` 
            SET `product_name`='$pn',`product_price`='$pp',`product_description`='$pd' 
            WHERE product_id = '$getId'";
     
             $query = mysqli_query($conn, $upd);
     
             if($query){
                 echo "<script>
            alert('product Updated');
            window.location.href = 'viewProduct.php';
            </script>";
             } 
        }
    }

include("footer.php");
?>