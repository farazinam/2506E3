<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\students;

class StudentController extends Controller
{
    public function welcome(){
        return view("welcome");
    }
    public function addstudentform(){
        return view("addstudent");
    }
    public function addstudent(Request $req){
        $std = new students();
        $std->name = $req["n"];
        $std->age = $req["a"];
        $std->email = $req["e"];
        $std->course = $req["c"];
        $std->save();
        return redirect("readstudent")->withSuccess("Record Inserted");
    }
    public function readstudent(){
        $fetchData = students::all();
        $details = compact("fetchData");
        return view("readstudent")->with($details);
    }
    public function delete($id){
        $foundID = students::find($id);
        $foundID->delete();
        return redirect("readstudent")->withYes("Record Deleted");
    }
}
