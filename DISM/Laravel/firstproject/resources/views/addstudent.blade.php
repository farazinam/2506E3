<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1> This is CONTACT Page</h1>

    <form action="/addstudent" method="post">
        @csrf
        <label for="">Student Name</label>
        <input type="text" name="n"> <br>
        <label for="">Student Age</label>
        <input type="text" name="a"> <br>
        <label for="">Student Email</label>
        <input type="text" name="e"> <br>
        <label for="">Student Course</label>
        <input type="text" name="c"> <br>
        <button type="submit">Add Data</button>
    </form>
</body>
</html>