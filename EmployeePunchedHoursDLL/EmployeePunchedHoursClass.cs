/* Title:           Employee Punched Hours Class
 * Date:            10-12-18
 * Author:          Terrance Holmes
 * 
 * Description:     This is the class that does all employee hours */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace EmployeePunchedHoursDLL
{
    public class EmployeePunchedHoursClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        EmployeePunchedHoursDataSet aEmployeePunchedHoursDataSet;
        EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter aEmployeePunchedHoursTableAdapter;

        InsertEmployeePunchedHoursEntryTableAdapters.QueriesTableAdapter aInsertEmployeePunchedHoursTableAdapter;

        FindEmployeePunchedHoursDataSet aFindEmployeePunchedHoursDataSet;
        FindEmployeePunchedHoursDataSetTableAdapters.FindEmployeePunchedHoursTableAdapter aFindEmployeePunchedHoursTableAdapter;

        FindAllEmployeePunchedHoursDataSet aFindAllEmployeePunchedHoursDataSet;
        FindAllEmployeePunchedHoursDataSetTableAdapters.FindAllEmployeePunchedHoursTableAdapter aFindAllEmployeePunchedHoursTableAdapter;

        FindEmployeePunchesByManagerIDDataSet aFindEmployeePunchesByManagerIDDataSet;
        FindEmployeePunchesByManagerIDDataSetTableAdapters.FindEmployeePunchesByManagerIDTableAdapter aFindEmployeePunchesByManagerIDTableAdapter;

        public FindEmployeePunchesByManagerIDDataSet FindEmployeePunchesByManagerID(int intManagerID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeePunchesByManagerIDDataSet = new FindEmployeePunchesByManagerIDDataSet();
                aFindEmployeePunchesByManagerIDTableAdapter = new FindEmployeePunchesByManagerIDDataSetTableAdapters.FindEmployeePunchesByManagerIDTableAdapter();
                aFindEmployeePunchesByManagerIDTableAdapter.Fill(aFindEmployeePunchesByManagerIDDataSet.FindEmployeePunchesByManagerID, intManagerID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employee Punches By Manager ID " + Ex.Message);
            }

            return aFindEmployeePunchesByManagerIDDataSet;
        }
        public FindAllEmployeePunchedHoursDataSet FindAllEmployeesPunchedHours(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllEmployeePunchedHoursDataSet = new FindAllEmployeePunchedHoursDataSet();
                aFindAllEmployeePunchedHoursTableAdapter = new FindAllEmployeePunchedHoursDataSetTableAdapters.FindAllEmployeePunchedHoursTableAdapter();
                aFindAllEmployeePunchedHoursTableAdapter.Fill(aFindAllEmployeePunchedHoursDataSet.FindAllEmployeePunchedHours, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find All Employees Punched Hours " + Ex.Message);
            }

            return aFindAllEmployeePunchedHoursDataSet;
        }
        public FindEmployeePunchedHoursDataSet FindEmployeePunchedHours(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeePunchedHoursDataSet = new FindEmployeePunchedHoursDataSet();
                aFindEmployeePunchedHoursTableAdapter = new FindEmployeePunchedHoursDataSetTableAdapters.FindEmployeePunchedHoursTableAdapter();
                aFindEmployeePunchedHoursTableAdapter.Fill(aFindEmployeePunchedHoursDataSet.FindEmployeePunchedHours, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employee Punched Hours " + Ex.Message);
            }

            return aFindEmployeePunchedHoursDataSet;
        }
        public bool InsertEmployeePunchedHours(DateTime datTransactionDate, int intEmployeeID, int intPayID, decimal decHours)
        {
            bool blnFatatError = false;

            try
            {
                aInsertEmployeePunchedHoursTableAdapter = new InsertEmployeePunchedHoursEntryTableAdapters.QueriesTableAdapter();
                aInsertEmployeePunchedHoursTableAdapter.InsertEmployeePunchedHours(datTransactionDate, intEmployeeID, intPayID, decHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Insert Employee Punched Hours " + Ex.Message);

                blnFatatError = true;
            }

            return blnFatatError;
        }
        public EmployeePunchedHoursDataSet GetEmployeePunchedHoursInfo()
        {
            try
            {
                aEmployeePunchedHoursDataSet = new EmployeePunchedHoursDataSet();
                aEmployeePunchedHoursTableAdapter = new EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter();
                aEmployeePunchedHoursTableAdapter.Fill(aEmployeePunchedHoursDataSet.employeepunchedhours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Get Employee Punched Hours Info " + Ex.Message);
            }

            return aEmployeePunchedHoursDataSet;
        }
        public void UpdateEmployeePunchedHoursDB(EmployeePunchedHoursDataSet aEmployeePunchedHoursDataSet)
        {
            try
            {
                aEmployeePunchedHoursTableAdapter = new EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter();
                aEmployeePunchedHoursTableAdapter.Update(aEmployeePunchedHoursDataSet.employeepunchedhours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Update Employee Punched Hours DB " + Ex.Message);
            }
        }
    }
}
