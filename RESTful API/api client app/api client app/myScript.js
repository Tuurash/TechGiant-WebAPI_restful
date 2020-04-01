$(document).ready(function(){

	$("#load").click(function(){
		loadData();
	});

	$("#create").click(function(){
		postData();
	});
	$("#delete").click(function(){
		deleteData();
	});

	function loadData()
	{
		$.ajax({
			url:"http://localhost:4468/api/departments",
			method:"get",
			headers:{
				Authorization:"Basic "+btoa("admin:123")
			},
			complete:function(xmlHttp,status){
				if(xmlHttp.status==200)
				{
					var data=xmlHttp.responseJSON;
					var str='';
					for (var i = 0; i < data.length; i++) {
						str+="<tr><td>"+data[i].departmentId+"</td><td>"+data[i].departmentName+"</td><td>"+data[i].location+"</td></tr>";
					};

					$("#list tbody").html(str);

				}
				else
				{
					$("#msg").html(xmlHttp.status+":"+xmlHttp.statusText);
				}
			}
		});
	}

function postData()
{
	$.ajax({
			url:"http://localhost:4468/api/departments",
			method:"post",
			headers:{
				ContentType:"application/json"
			},
			data:{
				departmentName:$("#deptName").val(),
				location:$("#deptLoc").val()
			},
			complete:function(xmlHttp,status){
				if(xmlHttp.status==201)
				{
					$("#msg").html("Department Created");
					loadData();
				}
				else
				{
					$("#msg").html(xmlHttp.status+":"+xmlHttp.statusText);
				}
			}
		});
}

function deleteData()
{
	var id=$("#deptId").val();
	$.ajax({
			url:"http://localhost:4468/api/departments/"+id,
			method:"delete",
			complete:function(xmlHttp,status){
				if(xmlHttp.status==204)
				{
					$("#msg").html("Department Deleted");
					loadData();
				}
				else
				{
					$("#msg").html(xmlHttp.status+":"+xmlHttp.statusText);
				}
			}
		});
}

});