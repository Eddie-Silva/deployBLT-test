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


 function get_text(id) {
   var text = document.getElementById("id").textContent;
   document.getElementById("demo").innerHTML = text;  

 }

 function only_text() {
   var bodyScripts = document.querySelectorAll("body script");
   for(var i=0; i<bodyScripts.length; i++){
       bodyScripts[i].remove();
   }
   var str = document.body.textContent;
   document.body.innerHTML = '<pre>'+str+'</pre>';
 }

// -----------js code to download file -----------
 function download(filename, text) {
   var element = document.createElement('a');
   element.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(text));
   element.setAttribute('download', filename);

   element.style.display = 'none';
   document.body.appendChild(element);

   element.click();

   document.body.removeChild(element);
}

// Start file download.
document.getElementById("dwn-btn").addEventListener("click", function(){

   // Generate download of "file".txt with some content
   var text = document.getElementById("text-val").textContent;
   var filename = "hello.txt";
   
   download(filename, text);
}, false);

// -----------END of js code to download file -----------