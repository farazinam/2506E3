<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\StudentController;


Route::get('/', [StudentController::class, 'welcome']);
Route::get('/contact', [StudentController::class, 'contact']);
 