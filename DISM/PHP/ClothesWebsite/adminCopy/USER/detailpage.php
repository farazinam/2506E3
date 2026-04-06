  <?php
  include "../config.php";  
  include "header.php";  

  $getId = $_GET["id"];
$sel = "SELECT * FROM product WHERE product_id = '$getId'";
$query = mysqli_query($conn, $sel);

$fetch = mysqli_fetch_array($query);
  ?>
  

<div class="modal-dialog " role="document">
		    	<div class="modal-content">
			      	<div class="modal-body">
			        	<div class="row">
			        		<div class="col-md-8 col-sm-6 col-xs-12">
			        			<div class="modal-image">
				        			<img class="img-responsive" src="../upload/<?php echo $fetch["product_image"]?>" alt="product-img" />
			        			</div>
			        		</div>
			        		<div class="col-md-4 col-sm-6 col-xs-12">
			        			<div class="product-short-details">
			        				<h2 class="product-title"><?php echo $fetch["product_name"]?></h2>
			        				<p class="product-price"><?php echo $fetch["product_price"]?></p>
			        				<p class="product-short-description">
			        					<?php echo $fetch["product_description"]?>
			        				</p>
			        				<a href="cart.html" class="btn btn-main">Buy Now</a> <br> <br>
			        				<a href="cart.html" class="btn btn-main">Add To Cart</a>
			        				<a href="product-single.html" class="btn btn-transparent">View Product Details</a>
			        			</div>
			        		</div>
			        	</div>
			        </div>
		    	</div>
		  	</div>


              <?php  
  include "footer.php";
  ?>