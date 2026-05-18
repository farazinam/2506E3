<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>
<body>
    <h1> Student records </h1>

    @if($get = Session::get('success'))
    <div class="alert alert-success">
        {{$get}}
    </div>
    @endif

    <table class="table table-hover table-stripped">
        <tr class="table-dark">
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Age</th>
            <th>Student Email</th>
            <th>Student Course</th>
            <th>Created At</th>
            <th>Action</th>
        </tr>

        @foreach ($fetchData as $item)
        <tr>
            <td>{{$item->id}}</td>
            <td>{{$item->name}}</td>
            <td>{{$item->age}}</td>
            <td>{{$item->email}}</td>
            <td>{{$item->course}}</td>
            <td>{{$item->created_at}}</td>
            <td>
                <a href="" class="btn btn-warning"><i class="bi bi-pencil-square"></i></a>
                <a href="{{route('del_route', ['id' => $item->id])}}" class="btn btn-danger"><i class="bi bi-trash3-fill"></i></a>
            </td>
        </tr>
        @endforeach

    </table>
</body>
</html>