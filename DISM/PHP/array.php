<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    

<?php 

 echo("<h2> Array </h2>");
   echo("<h3> Indexed </h3>");

   //Method 1
$ind1 = array("A", "B", "C");
   var_dump($ind1);

   //Method 2
   $ind2 = [2, 4, 6, 8, 10];
   echo($ind2[0]);
   echo($ind2[1]);
   echo($ind2[2]);

   print("<br>");

   print_r($ind1);

   print("<br>");

   echo($ind1[0]);
   echo($ind1[1]);
   echo($ind1[2]);                              

   print("<br>");

   for($a = 0; $a < 3; $a++){
      echo($ind1[$a]);
   }
   print("<br>");

   foreach($ind2 as $data){
      echo($data);
   }

   echo("<h3> Multi-Dimentional </h3>");

   $md1 = [
      ["Ali", "Ahmed", "Arham"],
      [1, 3, 5, 7, 9],
      [true, false],
      [
         [2.5, 7.9, 8.3],
         [2]
      ]
   ];

   echo($md1[1][3]);
   echo($md1[3][0][1]);


   echo("<h3> Associative </h3>");

   $aa = Array(
      "name" => "Ali",
      "age" => 23,
      "city" => "Karachi"
   );
   
   echo($aa["name"]);
   echo($aa["age"]);
   echo($aa["city"]);
   
   print("<br>");

   foreach($aa as $k){
      echo($k);
   }

   print("<br>");

   foreach($aa as $k => $v){
      echo($k . " " . $aa[$k]. "<br>");
   }


   //SOrting Array

   $a = [2, 6, 1, 7, 4];
//    $sorted = sort($a);
   $revsorted = rsort($a);

   foreach($a as $s){
      echo($s . "<br>");
   }

   $aaa = Array(
      "name" => "Ali",
      "age" => 23,
      "city" => "Karachi"
   );

//    $assocSort = asort($aaa);
   $assocRevSort = arsort($aaa);
   
   foreach($aaa as $s){
      echo($s . "<br>");
   }




?>
</body>
</html>