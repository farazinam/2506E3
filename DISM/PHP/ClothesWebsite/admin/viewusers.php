<?php 
include("config.php");
include("header.php");

  $fetch = "SELECT * FROM users WHERE role_id = 2";  //
  $query = mysqli_query($conn, $fetch);
?>

            <!-- Table Start -->
            <div class="container-fluid pt-4 px-4">
                <div class="row g-4">
                    <div class="col-sm-12 col-xl-12">
                        <div class="bg-light rounded h-100 p-4">
                            <h6 class="mb-4">All User</h6> 
                            <table class="table table-hover">
                                <thead class="table-dark">
                                    <tr>
                                        <th scope="col">User ID</th>
                                        <th scope="col">User Name</th>
                                        <th scope="col">User Email</th>
                                        <th scope="col">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <?php while($data = mysqli_fetch_array($query)){ ?>
                                    <tr>
                                        <th scope="row"> <?php echo $data["user_id"] ?></th>
                                        <td> <?php echo $data["username"] ?></td>
                                        <td> <?php echo $data["email"] ?></td>
                                        <td>
                                            <a class="btn btn-danger" href="deleteProduct.php?id=<?php echo $data[0] ?>"><i class="bi bi-trash-fill"></i></a>
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