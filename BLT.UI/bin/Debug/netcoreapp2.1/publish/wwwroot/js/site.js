// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function toggle_div(id) {

    var divelement = document.getElementById(id);

    if(divelement.style.display == 'block')
       divelement.style.display = 'none';
    else
       divelement.style.display = 'block';

 }

 function toggle_captions_visibility(id) {

    var divelement = document.getElementById(id);

       divelement.style.visibility = "visible";

 }

 function show_block(id) {

    document.getElementById(id).style.display='block';
 }

 function hide_block(id) {

    document.getElementById(id).style.display='none';
 }

