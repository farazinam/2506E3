<?php
include "../admin/config.php";
include "header.php";

$getId = $_GET['id'];

$sel = "SELECT * FROM product WHERE product_id = '$getId'";
$q = mysqli_query($conn, $sel);

$fetch = mysqli_fetch_array($q);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div class="container m-5">
        <div class="row">
            <div class="col col-lg-6 col-md-6 col-sm-12">
                <img src="../admin/upload/<?php echo $fetch['product_image'] ?>" width="300px" alt="">
            </div>
            <div class="col col-lg-6 col-md-6 col-sm-12 mt-5">
                Product Name: <h2><?php echo $fetch['product_name'] ?></h2>
                Product Price: <h2><?php echo $fetch['product_price'] ?></h2>
                Product Description: <h2><?php echo $fetch['product_description'] ?></h2>
                <hr>
                <label for="">Quantity</label>
                <input type="number" min="1" max="10" value="1">
                <br> <br>
                <a class="btn btn-warning" href="">Add to Cart</a>
                <a class="btn btn-success" href="checkout.php?id=<?php echo $fetch['product_id'] ?>">Buy Now</a>
            </div>
        </div>
    </div>
</body>
</html>


<?php
include "footer.php";
?>