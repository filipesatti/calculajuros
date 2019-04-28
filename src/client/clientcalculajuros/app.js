var express = require('express');
var app = express();
var http = require('http');

//Arrange Client test cases
var testCases = [{
  valorinicial:100,
  meses:5,  
  caseid : 1
},{
  valorinicial:200,
  meses:10, 
  caseid : 2
},{
  valorinicial:500,
  meses:0, 
  caseid : 3
},{
  valorinicial:0,
  meses : 10,
  caseid : 4
}];

for (let index = 0; index < testCases.length; index++) {
  let optionsget = {
    host : 'localhost', 
    port : 51775,
    method : 'GET',
    path : '/api/calculajuros?valorinicial=' + testCases[index].valorinicial + '&meses=' + testCases[index].meses
  };
  console.info('\nOptions prepared:');
  console.info(optionsget);
  console.info('\nDo the GET call');
  
  // do the GET request
  var reqGet = http.request(optionsget, function(res) {
      console.log("\nstatusCode: ", res.statusCode);
      res.on('data', function(d) {
          console.info('GET result:\n');
          process.stdout.write(d);
          console.info('\n\nCall completed for test case: ' + testCases[index].caseid);
      });
  
  });
  
  reqGet.end();  
}


module.exports = app;
