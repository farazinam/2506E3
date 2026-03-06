<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="" method="POST">
        <label for="">Category Name</label>
        <input type="text" name="category">
        <button type="submit" name="addcat">Add Category</button>
    </form>

    <?php
    $conn = mysqli_connect("localhost", "root", "", "clothes");

    if(ISSET($_POST["addcat"])){
        $cat = $_POST["category"];
        
       $ins = "INSERT INTO category (category_name)
        VALUES ('$cat')";

        $query = mysqli_query($conn, $ins);

        if($query){
            echo "REcord Inserted!";
        }
    }
    ?>
</body>
</html>