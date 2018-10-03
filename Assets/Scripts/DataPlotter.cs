using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPlotter : MonoBehaviour {
	public string inputFile;
	public GameObject PointPrefab;
	public GameObject PointHolder;
	public GameObject FloatingText;

	public int columnX = 0;
	public int columnY = 1;
	public int columnZ = 2;
	public int column4 = 3;

	public string xName;
	public string yName;
	public string zName;
	public string ill;

	private List<Dictionary<string, object>> pointList;


	// Use this for initialization
	void Start () {
		pointList = CSVRead.Read(inputFile);
		List<string> columnList = new List<string>(pointList[1].Keys);

		xName = columnList[columnX];
		yName = columnList[columnY];
		zName = columnList[columnZ];
		ill = columnList[column4];

		for (var i = 0; i < pointList.Count; i++)
		{
			float x = System.Convert.ToSingle(pointList[i][xName])/20;
			float y = System.Convert.ToSingle(pointList[i][yName])/50;
			float z = System.Convert.ToSingle(pointList[i][zName])/20;
			GameObject point = Instantiate(PointPrefab, new Vector3(x,y,z), Quaternion.identity);

			point.transform.parent = PointHolder.transform;
			point.transform.name = "Weight: " + pointList[i][xName] + " Height: " +
															pointList[i][yName] + " Age: " + pointList[i][zName];
			Color colour;
			switch((int) pointList[i][ill])
			{
				case 0:
							colour = new Color(0,255,0);
							break;
				case 1:
							colour = new Color(1,0,0);
							break;
				case 2:
							colour = new Color(255,0,0);
							break;
				case 3:
							colour = new Color(0,0,0);
							break;
				default:
							colour = new Color(255,255,255);
							break;
			}
			point.GetComponent<Renderer>().material.color = colour;
			point.AddComponent<CollisionScript>();
			point.GetComponent<CollisionScript>().FloatingText = FloatingText;

		}
	}

	// Update is called once per frame

}
