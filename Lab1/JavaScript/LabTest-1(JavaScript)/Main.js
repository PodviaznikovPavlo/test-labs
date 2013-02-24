/**
 * Created with JetBrains WebStorm.
 * User: Podviaznikov
 * Date: 23.02.13
 * Time: 15:39
 * To change this template use File | Settings | File Templates.
 */

var perfectNumber = [];
var bound = 3000;
var naturalNumber;
function sum(naturalNumber){
	var s = 0;
	for(var i=1; i<=naturalNumber/2; i+=1)
	{
		if(naturalNumber%i==0)
			s+=i;
	}
	return s;
}

function isPerfect(){
	var somevar = false;
	var answer;
	for(var i=0; i<perfectNumber.length; i+=1)
	{
		if(perfectNumber[i] == $("#inputNumber").val())
		{
			somevar = true;
			break;
		}
	}
	if($("#inputNumber").val()<=3000&$("#inputNumber").val()>0)
	{
		if(somevar==true)
			answer = $("#answer").text("This is a perfect number");
		else
			answer =  $("#answer").text("This isn`t a perfect number");
	}
		else if(typeof($("#inputNumber").val())!=Number)
		{
			answer =  $("#answer").text("Please, input number, not string.(Notice: 0 < number <= 3000)");
		}
		return answer;
	}

function perfectNumberList()
{
	for(var i=1; i<=bound; i+=1)
	{
		if(i==sum(i))
			perfectNumber.push(i);
	}
}

function solve()
{
	perfectNumberList();
	isPerfect();
}





