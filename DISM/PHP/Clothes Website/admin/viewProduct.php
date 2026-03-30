<?php 
include("config.php");
include("header.php");

  $fetch = "SELECT * FROM product";  //
  $query = mysqli_query($conn, $fetch);
?>

            <!-- Table Start -->
            <div class="container-fluid pt-4 px-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-xl-12">
                        <div class="bg-light rounded h-100 p-4">
                            <h6 class="mb-4">All Product</h6> 
                            <table class="table table-hover">
                                <thead class="table-dark">
                                    <tr>
                                        <th scope="col">Product ID</th>
                                        <th scope="col">Product Name</th>
                                        <th scope="col">Product Price</th>
                                        <th scope="col">Product Description</th>
                                        <th scope="col">Product Image</th>
                                        <th scope="col">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <?php while($data = mysqli_fetch_array($query)){ ?>
                                    <tr>
                                        <th scope="row"> <?php echo $data[0] ?></th>
                                        <td> <?php echo $data[1] ?></td>
                                        <td> <?php echo $data[2] ?></td>
                                        <td> <?php echo $data[3] ?></td>
                                        <td> <img src="upload/<?php echo $data[4] ?>" alt="" width="100px"></td>
                                        <td>
                                            <a href="updateProduct.php?id=<?php echo $data[0] ?>">Edit</a>
                                            <a href="deleteProduct.php?id=<?php echo $data[0] ?>">Delete</a>
                                        </td>
                                    </tr>
                                    <?php } ?>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    
                </div>
            </div>
            <!-- Table End -->

<?php 
include("footer.php");
?>