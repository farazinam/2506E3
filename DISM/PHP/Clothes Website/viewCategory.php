<?php
  $conn = mysqli_connect("localhost", "root", "", "clothes");

  $fetch = "SELECT * FROM category";
  $query = mysqli_query($conn, $fetch);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <table border="1">
        <tr>
            <th>Category ID</th>
            <th>Category Name</th>
        </tr>

       <?php 
       while($data = mysqli_fetch_array($query)){ ?>
        <tr>
            <td> <?php echo($data[0]) ?> </td>
            <td> <?php echo($data[1]) ?> </td>
        </tr>
       <?php } ?>

    </table>
</body>
</html>