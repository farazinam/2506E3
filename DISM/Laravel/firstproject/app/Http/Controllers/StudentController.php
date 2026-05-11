<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class StudentController extends Controller
{
    public function welcome(){
        return view("welcome");
    }
    public function rabta(){
        return view("contact");
    }
}
