<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\StudentController;

// Route::get('/', [StudentController::class, 'welcome']);
// Route::get('/rabta', [StudentController::class, 'rabta']);
// Route::get('/about', [StudentController::class, 'about']);

Route::controller(StudentController::class)->group(function(){
    Route::get('/', 'welcome');
    Route::get('/readstudent', 'readstudent');
    Route::get('/addstudent', 'addstudentform');
    Route::post('/addstudent', 'addstudent');
});
