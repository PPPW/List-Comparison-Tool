import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.swt.graphics.Point;
import org.eclipse.swt.widgets.Text;

import java.io.File;
//import java.io.FilenameFilter;
//import java.nio.file.Files;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import org.apache.commons.io.FileUtils;
import org.apache.commons.io.FilenameUtils;
import org.apache.commons.io.filefilter.DirectoryFileFilter;
import org.apache.commons.io.filefilter.RegexFileFilter;
import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.Label;
import org.eclipse.wb.swt.SWTResourceManager;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.events.ModifyListener;
import org.eclipse.swt.events.ModifyEvent;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;

public class MainWindow {

	protected Shell shlListez;
	private Text file1;
	private Text path1;
	private Text pattern;
	private Text extension1;
	
	private String ext1 = "\\.txt", ext2 = "\\.txt";
    private List<String> files1String = new ArrayList<String>();
    private List<String> files2String = new ArrayList<String>();
    private Boolean ignoreTextChanged = false;
    private String pattern_;
    
    private Label label3;
    private Label count1;
    private Text file2;
    private Text path2;
    private Text duplicate;
    private Text onlyIn1;
    private Text onlyIn2;
    private Label label2;
    private Text field;
    private Button extractField;
    private Button noPath1;
    private Button basename1;
    private Button sort1;
    private Button uniq1;
    private Button compare;
    private Label label5;
    private Text extension2;
    private Button noPath2;
    private Button basename2;
    private Button sort2;
    private Button uniq2;
    private Label label6;
    private Label count2;
    private Label inBothLabel;
    private Label onlyInALabel;
    private Label onlyInBLabel;
    private Label countInBoth;
    private Label countOnlyA;
    private Label countOnlyB;

	/**
	 * Launch the application.
	 * @param args
	 */
	public static void main(String[] args) {
		try {
			MainWindow window = new MainWindow();
			window.open();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	/**
	 * Open the window.
	 */
	public void open() {
		Display display = Display.getDefault();
		createContents();
		shlListez.open();
		shlListez.layout();
		while (!shlListez.isDisposed()) {
			if (!display.readAndDispatch()) {
				display.sleep();
			}
		}
	}

	/**
	 * Create contents of the window.
	 */
	protected void createContents() {
		shlListez = new Shell();
		shlListez.setMinimumSize(new Point(1128, 607));
		shlListez.setSize(450, 300);
		shlListez.setText("ListEZ");
		
		file1 = new Text(shlListez, SWT.MULTI | SWT.BORDER | SWT.WRAP | SWT.V_SCROLL);
		file1.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				if (ignoreTextChanged) return;
				files1String = changeFilesByTyping(file1, files1String, count1);
			}
		});
		file1.setTouchEnabled(true);
		file1.setBounds(23, 104, 329, 425);
		
		Label label1 = new Label(shlListez, SWT.NONE);
		label1.setFont(SWTResourceManager.getFont(".SF NS Text", 13, SWT.BOLD));
		label1.setBounds(12, 14, 52, 20);
		label1.setText("(a) Dir:");
		
		path1 = new Text(shlListez, SWT.BORDER);
		path1.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				ignoreTextChanged = true;
				files1String = getFilesGivenDir(path1, file1, files1String, count1, ext1);
	            ignoreTextChanged = false;
			}
		});
		path1.setBounds(70, 13, 282, 23);
		
		pattern = new Text(shlListez, SWT.BORDER);
		pattern.setText(".*?\\.(.*)");
		pattern.setBounds(70, 42, 212, 20);
		
		Button match = new Button(shlListez, SWT.NONE);
		match.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				pattern_ = pattern.getText();
				if (files1String != null)
	            {	                
	                files2String = new ArrayList<String> ();
	                for (String s : files1String) {
	                	Pattern r = Pattern.compile(pattern_);	                    
	                    Matcher m = r.matcher(s);
	                    if (m.find()) {
	                    	files2String.add(m.group(1));
	                    }
	                }
	                
	                ignoreTextChanged = true;
	                file2.setText(String.join("\n", files2String));
	                ignoreTextChanged = false;	                
	                count2.setText(Integer.toString(files2String.size()));
	            }
			}
		});
		match.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		match.setBounds(293, 42, 59, 20);
		match.setText("match");
		
		Label label4 = new Label(shlListez, SWT.NONE);
		label4.setBounds(27, 71, 55, 13);
		label4.setText("extension:");
		
		extension1 = new Text(shlListez, SWT.BORDER);
		extension1.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				if (extension1.getText().equals(""))
	                ext1 = "";
	            else
	                ext1 = "\\." + extension1.getText();
	            ignoreTextChanged = true;
	            files1String = getFilesGivenDir(path1, file1, files1String, count1, ext1);            
	            ignoreTextChanged = false;
			}
		});
		extension1.setText("txt");
		extension1.setBounds(88, 68, 40, 20);
		
		label3 = new Label(shlListez, SWT.NONE);
		label3.setBounds(20, 532, 41, 13);
		label3.setText("Count:");
		
		count1 = new Label(shlListez, SWT.NONE);
		count1.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		count1.setBounds(67, 532, 10, 13);
		
		file2 = new Text(shlListez, SWT.MULTI | SWT.BORDER | SWT.WRAP | SWT.V_SCROLL);
		file2.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				if (ignoreTextChanged) return;
				if (file2.getText() == null)
	            {
	                compare.setText("check dups in (a)");
	                inBothLabel.setText("dups in (a):");
	                onlyInALabel.setText("uniqs in (a):");
	                onlyInBLabel.setText("");
	                countOnlyB.setText("");
	            }
	            else
	            {
	                compare.setText("compare (a) && (b)");
	                inBothLabel.setText("In both:");
	                onlyInALabel.setText("Only in (a):");
	                onlyInBLabel.setText("Only in (b):");
	            }				
				files2String = changeFilesByTyping(file2, files2String, count2);
			}
		});
		file1.setTouchEnabled(true);
		file2.setBounds(377, 104, 329, 426);
		
		path2 = new Text(shlListez, SWT.BORDER);
		path2.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				ignoreTextChanged = true;
				files2String = getFilesGivenDir(path2, file2, files2String, count2, ext2);
	            ignoreTextChanged = false;
			}
		});
		path2.setBounds(422, 13, 282, 23);
		
		duplicate = new Text(shlListez, SWT.BORDER | SWT.WRAP | SWT.V_SCROLL | SWT.MULTI);
		duplicate.setEditable(false);
		duplicate.setBounds(771, 55, 329, 161);
		
		onlyIn1 = new Text(shlListez, SWT.BORDER | SWT.WRAP | SWT.V_SCROLL | SWT.MULTI);
		onlyIn1.setEditable(false);
		onlyIn1.setBounds(771, 222, 329, 161);
		
		onlyIn2 = new Text(shlListez, SWT.BORDER | SWT.WRAP | SWT.V_SCROLL | SWT.MULTI);
		onlyIn2.setEditable(false);
		onlyIn2.setBounds(771, 389, 329, 161);
		
		label2 = new Label(shlListez, SWT.NONE);
		label2.setText("(b) Dir:");
		label2.setFont(SWTResourceManager.getFont(".SF NS Text", 13, SWT.BOLD));
		label2.setBounds(364, 14, 52, 20);
		
		field = new Text(shlListez, SWT.BORDER);
		field.setText("0");
		field.setBounds(440, 43, 40, 20);
		
		extractField = new Button(shlListez, SWT.NONE);
		extractField.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {		                   
				int field_;
				try {
					field_ = Integer.parseInt(field.getText());
					if (field_ == 0)
	                    return;
					ArrayList<String> tmp = new ArrayList<String> ();
					for (String s : files2String) {
						if (s.equals("")) continue;						
						String[] fields = s.split("\t");
						if (fields.length >= field_) {
							tmp.add(fields[field_-1]);
						}
						else
							tmp.add(s);
					}
					files2String = tmp;
				}
				catch (Exception ex) {}
		            
				ignoreTextChanged = true;
				file2.setText(String.join("\n", files2String));
				ignoreTextChanged = false;
				
		        }                		       			
		});
		extractField.setText("extract field");
		extractField.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		extractField.setBounds(486, 43, 90, 20);
		
		noPath1 = new Button(shlListez, SWT.NONE);
		noPath1.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files1String = getFileNames(file1, files1String);                
	            ignoreTextChanged = false;
			}
		});
		noPath1.setText("no path");
		noPath1.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		noPath1.setBounds(129, 68, 60, 20);
		
		basename1 = new Button(shlListez, SWT.NONE);
		basename1.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files1String = getBasenames(file1, files1String);     
	            ignoreTextChanged = false;
			}
		});
		basename1.setText("basename");
		basename1.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		basename1.setBounds(184, 68, 70, 20);
		
		sort1 = new Button(shlListez, SWT.NONE);
		sort1.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files1String = sortFiles(file1, files1String);
	            ignoreTextChanged = false;
			}
		});
		sort1.setText("sort");
		sort1.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		sort1.setBounds(249, 68, 52, 20);
		
		uniq1 = new Button(shlListez, SWT.NONE);
		uniq1.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files1String = uniqFiles(file1, files1String, count1);
	            ignoreTextChanged = false;
			}
		});
		uniq1.setText("uniq");
		uniq1.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		uniq1.setBounds(296, 68, 56, 20);
		
		compare = new Button(shlListez, SWT.NONE);
		compare.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				if (files1String != null)
	            {
	                // assert files2String can't be null
	                if (files2String.size() != 0)
	                {	                		                   
	                	HashSet<String> onlyIn1String = new HashSet<String> (files1String);
	                    onlyIn1String.removeAll(files2String);
	                    onlyIn1.setText(String.join("\n", onlyIn1String));
	                    countOnlyA.setText(Integer.toString(onlyIn1String.size()));
	                    
	                    HashSet<String> onlyIn2String = new HashSet<String> (files2String);
	                    onlyIn2String.removeAll(files1String);
	                    onlyIn2.setText(String.join("\n", onlyIn2String));
	                    countOnlyB.setText(Integer.toString(onlyIn2String.size()));
	                    
	                    // intersection
	                    HashSet<String> dups = new HashSet<String> (files1String);
	                    dups.removeAll(onlyIn1String);
	                    duplicate.setText(String.join("\n", dups));
	                    countInBoth.setText(Integer.toString(dups.size()));
	                }
	                else
	                {	                   	                   
	                	HashSet<String> uniqs = new HashSet<String> ();
	                	HashSet<String> dups = new HashSet<String> ();
	                    for (String s : files1String) {	                    	
	                    	if (uniqs.contains(s)) {
	                    		if (!dups.contains(s))
	                    			dups.add(s);
	                    	}
	                    	else
	                    		uniqs.add(s);
	                    }
	                    //uniqs.removeAll(dups);
	                    
	                    duplicate.setText(String.join("\n", dups));
	                    countInBoth.setText(Integer.toString(dups.size()));
	                    
	                    onlyIn1.setText(String.join("\n", uniqs));
	                    countOnlyA.setText(Integer.toString(uniqs.size()));

	                    onlyIn2.setText("");
	                    countOnlyB.setText("");
	                }
	            }
			}
		});
		compare.setText("check dups in (a)");
		compare.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		compare.setBounds(771, 29, 115, 20);
		
		label5 = new Label(shlListez, SWT.NONE);
		label5.setText("extension:");
		label5.setBounds(377, 74, 55, 13);
		
		extension2 = new Text(shlListez, SWT.BORDER);
		extension2.addModifyListener(new ModifyListener() {
			public void modifyText(ModifyEvent arg0) {
				if (extension2.getText().equals(""))
	                ext2 = "";
	            else
	                ext2 = "\\." + extension2.getText();
	            ignoreTextChanged = true;
	            files2String = getFilesGivenDir(path2, file2, files2String, count2, ext2);            
	            ignoreTextChanged = false;
			}
		});
		extension2.setText("txt");
		extension2.setBounds(438, 71, 40, 20);
		
		noPath2 = new Button(shlListez, SWT.NONE);
		noPath2.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files2String = getFileNames(file2, files2String);                
	            ignoreTextChanged = false;
			}
		});
		noPath2.setText("no path");
		noPath2.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		noPath2.setBounds(479, 71, 60, 20);
		
		basename2 = new Button(shlListez, SWT.NONE);
		basename2.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files2String = getBasenames(file2, files2String);     
	            ignoreTextChanged = false;
			}
		});
		basename2.setText("basename");
		basename2.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		basename2.setBounds(534, 71, 70, 20);
		
		sort2 = new Button(shlListez, SWT.NONE);
		sort2.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files2String = sortFiles(file2, files2String);
	            ignoreTextChanged = false;
			}
		});
		sort2.setText("sort");
		sort2.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		sort2.setBounds(599, 71, 52, 20);
		
		uniq2 = new Button(shlListez, SWT.NONE);
		uniq2.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				ignoreTextChanged = true;
				files2String = uniqFiles(file2, files2String, count2);
	            ignoreTextChanged = false;
			}
		});
		uniq2.setText("uniq");
		uniq2.setFont(SWTResourceManager.getFont(".SF NS Text", 9, SWT.NORMAL));
		uniq2.setBounds(646, 71, 56, 20);
		
		label6 = new Label(shlListez, SWT.NONE);
		label6.setText("Count:");
		label6.setBounds(377, 532, 41, 13);
		
		count2 = new Label(shlListez, SWT.NONE);
		count2.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		count2.setBounds(424, 532, 10, 13);
		
		inBothLabel = new Label(shlListez, SWT.NONE);
		inBothLabel.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		inBothLabel.setBounds(707, 55, 59, 14);
		inBothLabel.setText("dups in (a):");
		
		onlyInALabel = new Label(shlListez, SWT.NONE);
		onlyInALabel.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		onlyInALabel.setText("uniqs in (a):");
		onlyInALabel.setBounds(707, 222, 59, 14);
		
		onlyInBLabel = new Label(shlListez, SWT.NONE);
		onlyInBLabel.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		onlyInBLabel.setBounds(707, 389, 59, 14);
		
		countInBoth = new Label(shlListez, SWT.NONE);
		countInBoth.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		countInBoth.setBounds(717, 71, 10, 13);
		
		countOnlyA = new Label(shlListez, SWT.NONE);
		countOnlyA.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		countOnlyA.setBounds(712, 239, 10, 13);
		
		countOnlyB = new Label(shlListez, SWT.NONE);
		countOnlyB.setFont(SWTResourceManager.getFont(".SF NS Text", 10, SWT.NORMAL));
		countOnlyB.setBounds(712, 409, 10, 13);

	}

	/**
	 * Helper functions 
	 */
	
	/**
	 * Search files given path 
	 */
	private List<String> getFilesGivenDir(Text path, Text file, List<String> filesString, Label count, String ext)
    {
        ignoreTextChanged = true;
        String dirName = path.getText().trim();
        if (dirName.equals("")) {
        	ignoreTextChanged = false;
            return filesString;
        }
        File dir = new File(dirName);
        if (dir.exists())
        {            
        	Collection<File> files = FileUtils.listFiles(
        			  dir, 
        			  new RegexFileFilter(".*" + ext), 
        			  DirectoryFileFilter.DIRECTORY
        			);
        	filesString = new ArrayList<String> ();
        	for (File f : files) {
        		filesString.add(f.getPath());
        	}
        	            
            file.setText(String.join("\n", filesString));
            count.setText(Integer.toString(filesString.size()));            
        }
        else
        {
        	file.setText("Dir not exist");
        }
        ignoreTextChanged = false;
        return filesString;
    }
	
	/**
	 * Remove path 
	 */
	private List<String> getFileNames(Text file, List<String> filesString)
    {
        if (filesString != null)
        {
        	ArrayList<String> filesNoPath = new ArrayList<String> ();
        	for (String s : filesString) {
        		filesNoPath.add(FilenameUtils.getName(s));
        	}            
            file.setText(String.join("\n", filesNoPath));
            filesString = filesNoPath;
        }
        return filesString;
    }
	
	/**
	 * Get base name 
	 */
	private List<String> getBasenames(Text file, List<String> filesString)
    {
        if (filesString != null)
        {            
            ArrayList<String> filesNoPath = new ArrayList<String> ();
        	for (String s : filesString) {
        		filesNoPath.add(FilenameUtils.getBaseName(s));
        	}            
            file.setText(String.join("\n", filesNoPath));
            filesString = filesNoPath;
        }
        return filesString;
    }
	
	/**
	 * Sort 
	 */
	private List<String> sortFiles(Text file, List<String> filesString) 
    {
        if (filesString != null)
        {
        	Collections.sort(filesString);
        	file.setText(String.join("\n", filesString));
        }
        return filesString;
    }
	
	/**
	 * Remove duplicated lines 
	 */
	private List<String> uniqFiles(Text file, List<String> filesString, Label count) 
    {
        if (filesString != null)
        {
        	HashSet<String> tmp = new HashSet<String> (filesString);
            filesString = new ArrayList<String> (tmp);
            file.setText(String.join("\n", filesString));
            count.setText(Integer.toString(filesString.size()));
        }
        return filesString;
    }
	
	/**
	 * Change content by typing 
	 */
	private List<String> changeFilesByTyping(Text file, List<String> filesString, Label count)
    {
        if (!ignoreTextChanged && file.getText() != null)
        {
        	filesString = new ArrayList<String> (Arrays.asList(file.getText().split("\n")));
        	ArrayList<String> filesStringTemp = new ArrayList<String> (filesString);
            // striping it here will create display problem, so save it to temp
            filesStringTemp.removeIf(item -> item == null || "".equals(item));
            //if (filesStringTemp.Length == 1)
            //    filesString = file.Text.Split(new string[] { "\t" }, StringSplitOptions.None);
            
            // show the content to user anyway, but stripped all empty strings  
            //ignoreTextChanged = true;
            //file.setText(String.join("\n", filesString));
            //ignoreTextChanged = false;
            filesString =  new ArrayList<String> (filesStringTemp);
            count.setText(Integer.toString(filesString.size()));
        }
        return filesString;
    }
}
